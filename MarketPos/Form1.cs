using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using MarketPos.Properties;
using MarketPos.FormPage;
using System.Drawing.Printing;
using System.Windows.Forms;
using System;
using System.Reflection.Emit;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Security.Principal;
using Konscious.Security.Cryptography;
using System.Security.Cryptography;
using System.Text;
using MarketPos.Models;
using MarketPos.FormPage.Manager;
using System.Collections.Generic;

namespace MarketPos
{
    public partial class Form1 : Form
    {
        public static string Imgpath = @"../../../ProductsImg";
        public static Member member = new();
        public static List<ProductsData> shelveProducts = [];
        public List<ProductsData> unshelveProducts = [];

        //key�Oid,value�O�ƶq
        private static List<OrderDetail> orderDetails = [];
        private List<ProductCard> productCards = [];
        private List<ProductCard> unShelveProductCards = [];
        private List<TabPage> tabPagesControl = [];
        private List<TabPage> tabPagesProduct = [];
        private int nextOrderNum;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            getProductCardsDatas(await DataService.P_getProductCardsDatas());

            //�]�w�̷s�q��s�� �榡ex:"yydddoooo"
            string latestOrderNum = (await DataService.Odr_getLatestOrderNum()).ToString();

            nextOrderNum = latestOrderNum.Substring(0, 5) == DateTime.Now.ToString("yy") + DateTime.Now.DayOfYear.ToString("D3") ?
                int.Parse(latestOrderNum) - (int.Parse(DateTime.Now.ToString("yy") + DateTime.Now.DayOfYear.ToString("D3") + "0000")) + 1 : 1;

            //��������Ҧ��d��
            productCards.Add(productCard1);
            productCards.Add(productCard2);
            productCards.Add(productCard3);
            productCards.Add(productCard4);
            productCards.Add(productCard5);
            productCards.Add(productCard6);
            productCards.Add(productCard7);
            productCards.Add(productCard8);

            unShelveProductCards.Add(productCard9);
            unShelveProductCards.Add(productCard10);
            unShelveProductCards.Add(productCard11);
            unShelveProductCards.Add(productCard12);
            unShelveProductCards.Add(productCard13);
            unShelveProductCards.Add(productCard14);
            unShelveProductCards.Add(productCard15);
            unShelveProductCards.Add(productCard16);

            //UI��l�ƥ�
            cb_Sort.SelectedIndex = 0;
            cb_Sort.SelectedIndexChanged += cb_Sort_SelectedIndexChanged;
            Detail_PCard.OrderItemAdded += Detail_PCard_OrderItemAdded;
            ShoppingCard.OrderItemChange += ShoppingCard_OrderItemChange;
            ShoppingCard.OrderItemDelete += ShoppingCard_OrderItemDelete;
            ShoppingCard.ConfirmedChange += ShoppingCard_ConfirmedChange;
            Mem_Detail_PCard.ChangeProduct += Mem_Detail_PCard_ChangeProduct;

            tabPagesControl = tbcControl.TabPages.Cast<TabPage>().ToList();
            tabPagesProduct = tbcProdut.TabPages.Cast<TabPage>().ToList();

            //�v���\���l��
            levelControl(4);

            //�Ȯɨϥ�
            productSort("�W��", true);
            Set_Page();
            cb_init();
        }

        private void getProductCardsDatas(List<ProductsData> datas)
        {
            shelveProducts = datas.Where(o => o.IsShelve).ToList();
            unshelveProducts = datas.Where(o => !o.IsShelve).ToList();
        }

        //�s�Wtab��Ш�o�̳]�w�v��
        private void levelControl(int level)
        {
#pragma warning disable CS8604 // �i�঳ Null �ѦҤ޼ơC

            tbcControl.TabPages.Clear();
            tbcProdut.TabPages.Clear();

            try
            {
                //�X���v��
                if (level <= 4)
                {
                    tbcControl.TabPages.Add(tabPagesControl.FirstOrDefault(o => o.Name == "tbMemSerch"));
                    tbcProdut.TabPages.Add(tabPagesProduct.FirstOrDefault(o => o.Name == "tbProduct"));
                }
                //�|���v��
                if (level == 3)
                {
                    tbcControl.TabPages.Add(tabPagesControl.FirstOrDefault(o => o.Name == "tbMenberEdit"));
                    tbcControl.TabPages.Add(tabPagesControl.FirstOrDefault(o => o.Name == "tbOrderHistory"));
                }
                //�޲z���v��
                if (level <= 2)
                {
                    tbcProdut.TabPages.Add(tabPagesProduct.FirstOrDefault(o => o.Name == "tbUnshelve"));
                    tbcControl.TabPages.Add(tabPagesControl.FirstOrDefault(o => o.Name == "tbAddProduct"));
                    tbcControl.TabPages.Add(tabPagesControl.FirstOrDefault(o => o.Name == "tbManOrder"));
                }
                //�t�γ̰��޲z��
                if (level == 1)
                {
                }
            }
            catch { MessageBox.Show("�X�{���j���~�v������"); }
#pragma warning disable CS8604 // �i�঳ Null �ѦҤ޼ơC
        }

        /// <summary>
        /// �̷ӭ����ӫ~�ƶq�������ƨ���ܥX��
        /// </summary>
        private void setProductCardsDatas(int page)
        {
            List<ProductsData> currentUI_Cards = [];

            productCards.ForEach(o => o.init());

            //�p��ݭn���Ӱ϶����ӫ~
            int uip_Count = productCards.Count;
            int first = uip_Count * page - uip_Count;
            int last = shelveProducts.Count - first < 8 ? shelveProducts.Count : first + uip_Count;

            //�N�ӫ~��ܥX��
            for (int i = first; i < last; i++)
                currentUI_Cards.Add(shelveProducts[i]);


            foreach (ProductsData product in currentUI_Cards)
            {
                setProductCardsData(product);
            }
        }

        /// <summary>
        /// �N��ƶ�J�٪ůʪ��d��
        /// </summary>
        private void setProductCardsData(ProductsData productsData)
        {
            var productCard = productCards.FirstOrDefault(o => o.ProductID == 0);
            productCard?.SetCard(productsData);
        }

        private void setUnShelveCardsDatas(int page)
        {
            //�޲z�̥\��
            if (member == null) return;
            if (member.Level > 2) return;

            List<ProductsData> currentUI_Cards = [];

            unShelveProductCards.ForEach(o => o.init());

            int uip_Count = unShelveProductCards.Count;
            int first = uip_Count * page - uip_Count;
            int last = unshelveProducts.Count - first < 8 ? unshelveProducts.Count : first + uip_Count;

            for (int i = first; i < last; i++)
                currentUI_Cards.Add(unshelveProducts[i]);

            foreach (ProductsData product in currentUI_Cards)
            {
                setUnShelveCard(product);
            }
        }

        private void setUnShelveCard(ProductsData productsData)
        {
            var productCard = unShelveProductCards.FirstOrDefault(o => o.ProductID == 0);
            productCard?.SetCard(productsData);
        }

        private void insertProduct()
        {
            ProductsData productData = new ProductsData
            {
                Name = txbAddP_name.Text.Trim(),
                Weight = Double.Parse(txbAddP_weight.Text.Trim()),
                Price = Decimal.Parse(txbAddP_price.Text.Trim()),
                Category = cbAddP_category.Text.Trim(),
                Description = rtbAddP_description.Text,
                Stock = cbAddP_stock.SelectedIndex,
                Origin = cbAddP_origin.Text
            };
            DataService.MP_insertProduct(productData);
        }

        /// <summary>
        /// true��desc,false��asce
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="mode"></param>
        public void productSort(string condition, bool mode)
        {
            if (condition == "�W��")
                shelveProducts.Sort((a, b) => mode ? -string.Compare(a.Name, b.Name) : string.Compare(a.Name, b.Name));
            else if (condition == "����")
                shelveProducts.Sort((a, b) => mode ? -a.Category.CompareTo(b.Category) : a.Category.CompareTo(b.Category));
            else if (condition == "����")
                shelveProducts.Sort((a, b) => mode ? -a.Price.CompareTo(b.Price) : a.Price.CompareTo(b.Price));
            else if (condition == "���q")
                shelveProducts.Sort((a, b) => mode ? -a.Weight.CompareTo(b.Weight) : a.Weight.CompareTo(b.Weight));
            else if (condition == "���a")
                shelveProducts.Sort((a, b) => mode ? -a.Origin.CompareTo(b.Origin) : a.Origin.CompareTo(b.Origin));
            else
            {
                MessageBox.Show("�ӫ~�ƧǥX�{���~");
                return;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //�T�{�ϥΪ̦��L��J�ƭ�
            if (string.IsNullOrEmpty(txbAddP_name.Text) ||
                string.IsNullOrEmpty(txbAddP_price.Text) ||
                string.IsNullOrEmpty(txbAddP_weight.Text))
            { MessageBox.Show("�п�J���T�����榡"); return; }

            //�T�{�ϥΪ̦��L��ܼƭ�
            if (cbAddP_origin.SelectedIndex == -1 ||
                cbAddP_stock.SelectedIndex == -1 ||
                cbAddP_category.SelectedIndex == -1)
            { MessageBox.Show("�п�ܥ��T�����"); return; }

            //�ϥΪ̽T�{���
            DialogResult result = MessageBox.Show($"�T�{�n�W�[�ӫ~:\n�W��:{txbAddP_name.Text}\n����:{cbAddP_category.Text}\n" +
                $"����:{txbAddP_price.Text}\n���q:{txbAddP_weight.Text}\n���a:{cbAddP_origin.Text}\n" +
                $"�w�s:{cbAddP_stock.Text}", "�T�{", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel) return;

            insertProduct();
        }

        //�����J���Ʀr
        private void checkNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        //�����J���K�X
        private void checkPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') ||
                (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (char.IsControl(e.KeyChar)))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private async void cbAddCategoryType_Click(object sender, EventArgs e)
        {
            UserInputForm userInput = new("�п�J�s�W�����O:")
            {
                StartPosition = FormStartPosition.CenterParent
            };

            //��J�T�{
            if (userInput.ShowDialog(this) == DialogResult.Cancel) return;
            if (string.IsNullOrEmpty(userInput.userinput)) return;

            await DataService.MP_AddCategoryType(userInput.userinput);
            cb_init();
        }

        private async void btnAddOriginType_Click(object sender, EventArgs e)
        {
            UserInputForm userInput = new("�п�J�s�W�����a:")
            {
                StartPosition = FormStartPosition.CenterParent
            };

            //��J�T�{
            if (userInput.ShowDialog(this) == DialogResult.Cancel) return;
            if (string.IsNullOrEmpty(userInput.userinput)) return;

            //�N�s���O��J��Ʈw
            await DataService.MP_AddOriginType(userInput.userinput);
            cb_init();
        }

        private void Set_Page()
        {
            int p_count = shelveProducts.Count;

            //�q��page����
            int page = (int)Math.Floor(p_count / 8d);
            if (p_count % 8 != 0) page++;

            cbPage.Items.Clear();
            for (int i = 1; i <= page; i++)
                cbPage.Items.Add(i.ToString());

            //���UI�ƭ�
            if (cbPage.Items.Count != 0) cbPage.SelectedIndex = 0;
            lbPage.Text = $"/{page}��";


            //�޲z�̥\��
            if (member == null) return;
            if (member.Level > 2) return;
            int unp_count = unshelveProducts.Count;

            //�q��page����
            page = (int)Math.Floor(unp_count / 8d);
            if (unp_count % 8 != 0) page++;

            cbUnPage.Items.Clear();
            for (int i = 1; i <= page; i++)
                cbUnPage.Items.Add(i.ToString());

            //���UI�ƭ�
            if (cbUnPage.Items.Count != 0) cbUnPage.SelectedIndex = 0;
            lbUnPage.Text = $"/{page}��";
        }

        private void cbPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            setProductCardsDatas(cbPage.SelectedIndex + 1);
        }
        private void cbUnPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            setUnShelveCardsDatas(cbUnPage.SelectedIndex + 1);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (cbPage.SelectedIndex != cbPage.Items.Count - 1)
                cbPage.SelectedIndex++;
        }

        private void btnBackPage_Click(object sender, EventArgs e)
        {
            if (cbPage.SelectedIndex > 0)
                cbPage.SelectedIndex--;
        }
        private void btnUnNextPage_Click(object sender, EventArgs e)
        {
            if (cbUnPage.SelectedIndex != cbUnPage.Items.Count - 1)
                cbUnPage.SelectedIndex++;
        }

        private void btnUnBackPage_Click(object sender, EventArgs e)
        {
            if (cbUnPage.SelectedIndex > 0)
                cbUnPage.SelectedIndex--;
        }

        //�N��ƶ�Jcb
        private async void cb_init()
        {
            cbAddP_category.Items.Clear();
            cbAddP_origin.Items.Clear();
            cbAddP_stock.Items.Clear();
            cbS_Category.Items.Clear();
            cbS_Origin.Items.Clear();
            await DataService.P_GetCategoryType();
            await DataService.P_GetOriginType();
            for (int i = 0; i < 100; i++)
                cbAddP_stock.Items.Add(i);

            cbAddP_category.DisplayMember = "Key";
            cbAddP_category.ValueMember = "Value";
            cbAddP_category.DataSource = new BindingSource(DataService.categorysDict, null);
            cbAddP_category.SelectedIndex = -1;

            cbS_Category.DisplayMember = "Key";
            cbS_Category.ValueMember = "Value";
            cbS_Category.DataSource = new BindingSource(DataService.categorysDict, null);
            cbS_Category.SelectedIndex = -1;

            cbAddP_origin.DisplayMember = "Key";
            cbAddP_origin.ValueMember = "Value";
            cbAddP_origin.DataSource = new BindingSource(DataService.originsDict, null);
            cbAddP_origin.SelectedIndex = -1;

            cbS_Origin.DisplayMember = "Key";
            cbS_Origin.ValueMember = "Value";
            cbS_Origin.DataSource = new BindingSource(DataService.originsDict, null);
            cbS_Origin.SelectedIndex = -1;
        }

        private async void btnS_Search_Click(object sender, EventArgs e)
        {
            ProductsData productData = new ProductsData();
            try
            {
                productData.Name = txbS_Name.Text.Trim();
                productData.Category = cbS_Category.Text;
                Decimal.TryParse(txbS_Price.Text.Trim(), out decimal price);
                productData.Price = price;
                double.TryParse(txbS_weight.Text.Trim(), out double weight);
                productData.Weight = weight;
                productData.Origin = cbS_Origin.Text;
            }
            catch (Exception ex) { MessageBox.Show($"��J���~{ex}"); return; }

            var data = await DataService.P_SelectProducts(productData, btnS_PriceToggle.Text == "�H�W", btnS_WeightToggle.Text == "�H�W");
            if (data.Where(o => o.IsShelve).Count() == 0 && member.Level < 3) { MessageBox.Show("�d�L�����"); return; }
            getProductCardsDatas(data);
            if (ptb_Sort.Tag == null)
            {
                MessageBox.Show("�䤣��ptb_Sort.tag");
                return;
            }
            productSort("�W��", ptb_Sort.Tag.ToString() == "descendingOrder");
            Set_Page();

        }

        private void btnS_WeightToggle_Click(object sender, EventArgs e)
        {
            if (btnS_WeightToggle.Text == "�H�W")
                btnS_WeightToggle.Text = "�H�U";
            else if (btnS_WeightToggle.Text == "�H�U")
                btnS_WeightToggle.Text = "�H�W";
        }

        private void btnS_PriceToggle_Click(object sender, EventArgs e)
        {
            if (btnS_PriceToggle.Text == "�H�W")
                btnS_PriceToggle.Text = "�H�U";
            else if (btnS_PriceToggle.Text == "�H�U")
                btnS_PriceToggle.Text = "�H�W";
        }

        private async void btnS_Clear_Click(object sender, EventArgs e)
        {
            txbS_Name.Text = "";
            txbS_Price.Text = "";
            txbS_weight.Text = "";
            cbS_Category.SelectedIndex = -1;
            cbS_Origin.SelectedIndex = -1;
            cb_Sort.SelectedIndex = 0;
            getProductCardsDatas(await DataService.P_getProductCardsDatas());
            if (ptb_Sort.Tag == null)
            {
                MessageBox.Show("�䤣��ptb_Sort.tag");
                return;
            }
            productSort("�W��", ptb_Sort.Tag.ToString() == "descendingOrder");
            Set_Page();
        }

        private void cb_Sort_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (ptb_Sort.Tag == null || sender == null) return;
            productSort(cb_Sort.Text, ptb_Sort.Tag.ToString() == "descendingOrder");
            setProductCardsDatas(1);
        }

        private void ptb_Sort_Click(object sender, EventArgs e)
        {
            if (ptb_Sort.Tag == null) return;
            if (ptb_Sort.Tag.ToString() == "descendingOrder")
            {
                ptb_Sort.Image = Resources.ascendingOrder;
                ptb_Sort.Tag = "ascendingOrder";
                productSort(cb_Sort.Text, false);
            }
            else if (ptb_Sort.Tag.ToString() == "ascendingOrder")
            {
                ptb_Sort.Image = Resources.descendingOrder;
                ptb_Sort.Tag = "descendingOrder";
                productSort(cb_Sort.Text, true);
            }
            Set_Page();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (member == null || member.Id == 0)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.StartPosition = FormStartPosition.CenterParent;
                loginForm.LoginSuccess += LoginForMem_LoginSuccess;
                loginForm.ShowDialog();
            }
            else
            {
                //�n�X�\��
                member = new Member();
                flp_shoppingCar.Controls.Clear();
                orderDetails = [];
                btn_Login.Text = "���U/�n�J";
                lbMember.Text = string.Empty;
                ptb_Buy.Enabled = false;
                ptb_Buy.Visible = false;
                levelControl(4);
            }
            btnS_Clear_Click(this, EventArgs.Empty);
        }
        private async void LoginForMem_LoginSuccess(object? sender, Member e)
        {
            if (sender == null) { MessageBox.Show("�n�J��������"); return; }
            if (e.Id == 0) { MessageBox.Show("�d�L���Τ�W��"); return; };

            member = e;

            //UI�]�m
            ptb_Buy.Enabled = true;
            ptb_Buy.Visible = true;
            levelControl(member.Level);
            setMemberProfile(false);

            //�|���q��B�z
            getShoppingOrderID();
            orderDetails = await DataService.Odr_GetOrderDetail(member.OrderId);
            setShoppingCard(orderDetails, flp_shoppingCar, true);
            setOrderHistroy();
            setManagerOrder();
        }

        private async void setOrderHistroy()
        {
            if (member == null || member.Id == 0) return;

            cbOdr_Number.DataSource = await DataService.Odr_getHistoryNum(member.Id);
        }

        private async void setManagerOrder()
        {
            if (member == null || member.Id == 0) return;

            cbMOdr_Number.DataSource = await DataService.Odr_getHistoryNum(0);
        }

        /// <summary>
        /// �p�ݭ��s����|����ƽжǤJtrue
        /// </summary>
        private async void setMemberProfile(bool mode)
        {
            if (member == null || member.Id == 0) return;
            if (mode) member = await DataService.Mem_Login(member.Account, member.HashPassword);

            lbMember.Text = $"�w��^��: {member.Name}";
            btn_Login.Text = "�n�X";
            if (member == null || member.Id == 0) return;
            txbMem_Name.Text = member.Name;
            txbMem_Email.Text = member.Email;
            txbMem_Address.Text = member.Address;
            txbMem_Phone.Text = member.Phone;
        }

        private async void getShoppingOrderID()
        {
            if (member == null || member.Id == 0) return;
            int orderid = await DataService.Odr_GetMemberOrderID(member.Id);
            if (orderid == 0)
            {
                await DataService.Odr_CreateNewOrder(Odr_getLatestOrderNum(), member.Id);
                orderid = await DataService.Odr_GetMemberOrderID(member.Id);
            }
            member.OrderId = orderid;
        }

        private void btntest_Click_1(object sender, EventArgs e)
        {

        }
        private int Odr_getLatestOrderNum()
        {
            return int.Parse(DateTime.Now.ToString("yy") + DateTime.Now.DayOfYear.ToString("D3") + nextOrderNum.ToString("0000"));
        }

        private async void Detail_PCard_OrderItemAdded(object? sender, OrderDetail e)
        {
            if (member == null || member.Id == 0) return;

            e.orderID = member.OrderId;
            if (!orderDetails.Any(o => o.productID == e.productID))
                await DataService.Odr_CreateOrderDetail(e);
            else
                await DataService.Odr_UpdateOrderDetail(e);

            orderDetails = await DataService.Odr_GetOrderDetail(member.OrderId);
            setShoppingCard(orderDetails, flp_shoppingCar, true);
            tbcControl.SelectedIndex = 0;
        }
        private async void Mem_Detail_PCard_ChangeProduct(object? sender, EventArgs e)
        {
            getProductCardsDatas(await DataService.P_getProductCardsDatas());
            if (ptb_Sort.Tag == null)
            {
                MessageBox.Show("�䤣��ptb_Sort.tag");
                return;
            }
            productSort("�W��", ptb_Sort.Tag.ToString() == "descendingOrder");
            Set_Page();
        }

        private async void ShoppingCard_OrderItemChange(object? sender, OrderDetail e)
        {
            await DataService.Odr_UpdateOrderDetail(e);
            orderDetails = await DataService.Odr_GetOrderDetail(e.orderID);
            setShoppingCard(orderDetails, flp_shoppingCar, true);
        }

        private async void ShoppingCard_OrderItemDelete(object? sender, int e)
        {
            if (member == null || member.Id == 0) return;

            await DataService.Odr_DeleteOrderDetail(member.OrderId, e);
            orderDetails = await DataService.Odr_GetOrderDetail(member.OrderId);
            setShoppingCard(orderDetails, flp_shoppingCar, true);
        }

        private async void ShoppingCard_ConfirmedChange(object? sender, OrderDetail e)
        {
            await DataService.Odr_UpdateOrderDetail(e);
            orderDetails = await DataService.Odr_GetOrderDetail(e.orderID);
            setShoppingCard(orderDetails, flp_shoppingCar, false);
        }

        /// <param name="orderDetail">�q��ԲӸ��</param>
        /// <param name="flp">�]�m������</param>
        private void setShoppingCard(List<OrderDetail> orderDetail, FlowLayoutPanel flp, bool isShoppingCar)
        {
            flp.Controls.Clear();
            foreach (var item in orderDetail)
            {
                ShoppingCard shoppingCard = new ShoppingCard(isShoppingCar);
                List<ProductsData> datas = [.. unshelveProducts, .. shelveProducts];

                ProductsData? productsData = datas.FirstOrDefault(o => o.Id == item.productID && (o.IsShelve || !isShoppingCar));

                if (productsData == null) { MessageBox.Show($"��L�����ӫ~:{item.productID}�A�лP�J�A�pô"); continue; }
                shoppingCard.SetCard(productsData, item);
                flp.Controls.Add(shoppingCard);
            }
        }

        /// <summary>
        /// �p���`���B
        /// </summary>
        private void flp_ControlChange(object sender, EventArgs e)
        {
            FlowLayoutPanel? flowLayoutPanel = sender as FlowLayoutPanel;
            if (flowLayoutPanel == null) return;

            //��ܭn�N���B��X�b����txb
            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
            if (flowLayoutPanel.Name == "flp_shoppingCar") textBox = txbTotal;
            else if (flowLayoutPanel.Name == "flpOdr_Histroy") textBox = txbOdr_Total;
            else if (flowLayoutPanel.Name == "flpMOdr") textBox = txbMOdr_Total;

            List<ShoppingCard> shoppingCards = flowLayoutPanel.Controls.OfType<ShoppingCard>().ToList();
            if (shoppingCards.Count == 0)
                textBox.Text = string.Empty;
            else textBox.Text = "�`���B:" + shoppingCards.Sum(o => o.total).ToString() + "$";
        }

        private async void ptb_Buy_Click(object sender, EventArgs e)
        {
            if (member == null || member.Id == 0) { MessageBox.Show("�Х��n�J�|��"); return; }
            if (orderDetails.Count == 0) { MessageBox.Show("�ʪ����ثe�O�ŪŪ�"); return; }

            PurchaseForm purchaseForm = new PurchaseForm();
            purchaseForm.StartPosition = FormStartPosition.CenterParent;
            purchaseForm.SetForm(member.OrderId);
            purchaseForm.ShowDialog();

            if (purchaseForm.DialogResult != DialogResult.OK) return;

            //�ק�q�檬�A
            if (await DataService.Odr_orderPlaced(member.OrderId, purchaseForm.payment, purchaseForm.OName,
                purchaseForm.OAddress, purchaseForm.RName, purchaseForm.RAddress, orderDetails))
            {
                MessageBox.Show("�q��U�榨�\");

                //��l�ƭq��
                getShoppingOrderID();
                orderDetails = await DataService.Odr_GetOrderDetail(member.OrderId);
                setShoppingCard(orderDetails, flp_shoppingCar, true);

                //���s����ӫ~���
                getProductCardsDatas(await DataService.P_getProductCardsDatas());
                if (ptb_Sort.Tag != null)
                    productSort(cb_Sort.Text, ptb_Sort.Tag.ToString() == "descendingOrder");
                Set_Page();
                setOrderHistroy();
            }
        }

        private async void btnMemberEdit_Click(object sender, EventArgs e)
        {
            if (member == null || member.Id == 0) return;

            string emailPattern =
                @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
            string phonePattern = @"^09\d{8}$";

            if (string.IsNullOrEmpty(txbMem_Name.Text)) { MessageBox.Show("�ж�J�n��諸�W�r"); return; }
            if (!string.IsNullOrEmpty(txbMem_Email.Text) && !Regex.IsMatch(txbMem_Email.Text, emailPattern))
            { MessageBox.Show("�ж�J���T��MAIL�a�}"); return; }
            if (!Regex.IsMatch(txbMem_Phone.Text, phonePattern) && !string.IsNullOrEmpty(txbMem_Phone.Text))
            { MessageBox.Show("�ж�J���T��������X"); return; }

            if (!await DataService.Mem_EditProfile(txbMem_Name.Text.Trim(), txbMem_Address.Text.Trim(),
                    txbMem_Email.Text.Trim(), txbMem_Phone.Text, member.Id))
                return;

            MessageBox.Show("�|���򥻸�Ƨ�s���\");
            setMemberProfile(true);
        }

        private async void btnAccountEdit_Click(object sender, EventArgs e)
        {
            if (member == null || member.Id == 0) return;

            string oldPassword = txbOldPassword.Text.Trim();
            string newPassword = txbPassword.Text.Trim();
            string check = txbCheck.Text.Trim();
            List<string> list = [oldPassword, newPassword, check];

            if (list.Any(string.IsNullOrEmpty)) { MessageBox.Show("�п�J�s�±K�X"); return; }
            if (!newPassword.Equals(check)) { MessageBox.Show("�K�X��J���@�P"); return; }
            if (newPassword.Length < 6) { MessageBox.Show("�п�J���T���K�X�榡�A�Фj��6�ӭ^��Ʀr"); return; }


            string oldSaltStr = await DataService.Mem_LoginGetSalt(member.Account);
            byte[] oldSalt = Convert.FromBase64String(oldSaltStr);
            byte[] oldHashpassword = GHashPassword(oldPassword, oldSalt);
            string oldHashpasswordStr = Convert.ToBase64String(oldHashpassword);
            if (member.HashPassword != oldHashpasswordStr) { MessageBox.Show("�±K�X�n�J���~"); return; }

            //�K�X�[�K
            byte[] newSalt = CreateSalt();
            string newSaltStr = Convert.ToBase64String(newSalt);
            byte[] newHashpassword = GHashPassword(newPassword, newSalt);
            string newHashpasswordStr = Convert.ToBase64String(newHashpassword);

            if (await DataService.Mem_EditAccount(newHashpasswordStr, newSaltStr, member.Account))
            {
                member = await DataService.Mem_Login(member.Account, newHashpasswordStr);
                if (member == null || member.Id == 0) MessageBox.Show("�X�{���~�лP�J�A�pô");
                MessageBox.Show("�K�X��令�\");
                txbOldPassword.Text = string.Empty;
                txbPassword.Text = string.Empty;
                txbCheck.Text = string.Empty;
            }
        }

        //�����Q��
        public static byte[] CreateSalt()
        {
            byte[] buffer = new byte[16];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(buffer);
            return buffer;
        }

        //hash�ӷ�https://ithelp.ithome.com.tw/articles/10266660
        public static byte[] GHashPassword(string password, byte[] salt)
        {
            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password));
            argon2.Salt = salt;
            argon2.DegreeOfParallelism = 4; // 4 �֤ߴN�]�� 8
            argon2.Iterations = 3; // ���N�B�⦸��
            argon2.MemorySize = 512 * 512;

            return argon2.GetBytes(16);
        }

        private void lb_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.Label? label = sender as System.Windows.Forms.Label;
            if (label == null) return;

            // �p���r�e�שM���Ҽe�ת����
            int minFontSize = 6;
            if (string.IsNullOrEmpty(label.Text)) return;
            float ratio = 200f / TextRenderer.MeasureText(label.Text, label.Font).Width;

            // �p�G��Ҥp��1�A�վ�r��j�p
            if (ratio < 1)
            {
                int newSize = (int)(label.Font.Size * ratio);
                newSize = Math.Max(newSize, minFontSize);
                label.Font = new Font(label.Font.FontFamily, newSize, label.Font.Style);
            }
        }

        private async void cbOdr_Number_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOdr_Number.SelectedValue == null) return;

            int orderid = (int)cbOdr_Number.SelectedValue;
            var orderDetails = await DataService.Odr_GetOrderDetail(orderid);
            var orderData = await DataService.Odr_GetOrderData(orderid);
            var paymentmethod = await DataService.Odr_GetPayment();

            setShoppingCard(orderDetails, flpOdr_Histroy, false);
            lbOdr_date.Text = "�q�ʤ�� : " + orderData.PlacedDate.ToString("yyyy�~MM��dd��");
            lbOdr_Payment.Text = "�I�ڤ覡 : " + paymentmethod[orderData.Payment];
            lbOdr_OName.Text = "�q�ʤH�m�W :" + orderData.OrdererName;
            txbOdr_OAdress.Text = orderData.OrdererAddress;
            lbOdr_RName.Text = "���f�H�m�W :" + orderData.ReceiverName;
            txbOdr_RAdress.Text = orderData.ReceiverAddress;
        }

        private async void cbMOdr_Number_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMOdr_Number.SelectedValue == null) return;

            int orderid = (int)cbMOdr_Number.SelectedValue;
            var orderDetails = await DataService.Odr_GetOrderDetail(orderid);
            var orderData = await DataService.Odr_GetOrderData(orderid);
            var paymentmethod = await DataService.Odr_GetPayment();

            setShoppingCard(orderDetails, flpMOdr, false);
            lbMOdr_Date.Text = "�q�ʤ�� : " + orderData.PlacedDate.ToString("yyyy�~MM��dd��");
            lbMOdr_Payment.Text = "�I�ڤ覡 : " + paymentmethod[orderData.Payment];
            lbMOdr_OName.Text = "�q�ʤH�m�W :" + orderData.OrdererName;
            txbMOdr_OAddress.Text = orderData.OrdererAddress;
            lbMOdr_RName.Text = "���f�H�m�W :" + orderData.ReceiverName;
            txbMOdr_RAddress.Text = orderData.ReceiverAddress;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

