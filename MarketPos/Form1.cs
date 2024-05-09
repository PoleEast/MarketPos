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

namespace MarketPos
{
    public partial class Form1 : Form
    {
        public static string Imgpath = @"../../../ProductsImg";
        public static List<ProductsData> productsDatas = [];
        public static Member? member;
        private static Dictionary<int, int> orderDetail = [];
        private List<ProductCard> productCards = [];
        private List<TabPage> tabPagesControl = [];
        private List<TabPage> tabPagesProduct = [];
        private int nextOrderNum;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await DataService.P_getProductCardsDatas();

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

            //UI��l�ƥ�
            cb_Sort.SelectedIndex = 0;
            cb_Sort.SelectedIndexChanged += cb_Sort_SelectedIndexChanged;
            Detail_PCard.OrderItemAdded += Detail_PCard_OrderItemAdded;
            ShoppingCard.OrderItemChange += ShoppingCard_OrderItemChange;
            ShoppingCard.OrderItemDelete += ShoppingCard_OrderItemDelete; ;

            tabPagesControl = tbcControl.TabPages.Cast<TabPage>().ToList();
            tabPagesProduct = tbcProdut.TabPages.Cast<TabPage>().ToList();

            //�v���\���l��
            levelControl(4);

            //�Ȯɨϥ�
            productSort("�W��", true);
            Set_Page();
            cb_init();
        }

        private void levelControl(int level)
        {

#pragma warning disable CS0252 // �i��~�ΰѦҤ��; ���ݻݭn�ഫ
            if (tabPagesControl.Any(o => o.Tag == "") || tabPagesProduct.Any(o => o.Tag == "")) MessageBox.Show($"�]�p���~Tab�v�����]�m");

            tbcControl.TabPages.Clear();
            tbcProdut.TabPages.Clear();


            if (level <= 4)
            {
                tbcControl.TabPages.AddRange(tabPagesControl.Where(o => o.Tag == "4").ToArray());
                tbcProdut.TabPages.AddRange(tabPagesProduct.Where(o => o.Tag == "4").ToArray());
            }
            if (level <= 3)
            {
                tbcControl.TabPages.AddRange(tabPagesControl.Where(o => o.Tag == "3").ToArray());
                tbcProdut.TabPages.AddRange(tabPagesProduct.Where(o => o.Tag == "3").ToArray());
            }
            if (level <= 2)
            {
                tbcControl.TabPages.AddRange(tabPagesControl.Where(o => o.Tag == "2").ToArray());
                tbcProdut.TabPages.AddRange(tabPagesProduct.Where(o => o.Tag == "2").ToArray());
            }
            if (level == 1)
            {
                tbcControl.TabPages.AddRange(tabPagesControl.Where(o => o.Tag == "1").ToArray());
                tbcProdut.TabPages.AddRange(tabPagesProduct.Where(o => o.Tag == "1").ToArray());
            }
#pragma warning restore CS0252 // �i��~�ΰѦҤ��; ���ݻݭn�ഫ
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
            int last = productsDatas.Count - first < 8 ? productsDatas.Count : first + uip_Count;

            //�N�ӫ~��ܥX��
            for (int i = first; i < last; i++)
                currentUI_Cards.Add(productsDatas[i]);
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
            var productCard = productCards.FirstOrDefault(o => o.Visible == false);
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
            DataService.P_insertProduct(productData);
        }

        /// <summary>
        /// true��desc,false��asce
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="mode"></param>
        public void productSort(string condition, bool mode)
        {
            if (condition == "�W��")
                productsDatas.Sort((a, b) => mode ? -string.Compare(a.Name, b.Name) : string.Compare(a.Name, b.Name));
            else if (condition == "����")
                productsDatas.Sort((a, b) => mode ? -a.Category.CompareTo(b.Category) : a.Category.CompareTo(b.Category));
            else if (condition == "����")
                productsDatas.Sort((a, b) => mode ? -a.Price.CompareTo(b.Price) : a.Price.CompareTo(b.Price));
            else if (condition == "���q")
                productsDatas.Sort((a, b) => mode ? -a.Weight.CompareTo(b.Weight) : a.Weight.CompareTo(b.Weight));
            else if (condition == "���a")
                productsDatas.Sort((a, b) => mode ? -a.Origin.CompareTo(b.Origin) : a.Origin.CompareTo(b.Origin));
            else
            {
                MessageBox.Show("�ӫ~�ƧǥX�{���~");
                return;
            }
            //UI�]�w
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

        private async void cbAddCategoryType_Click(object sender, EventArgs e)
        {
            UserInputForm userInput = new("�п�J�s�W�����O:")
            {
                StartPosition = FormStartPosition.CenterParent
            };

            //��J�T�{
            if (userInput.ShowDialog(this) == DialogResult.Cancel) return;
            if (string.IsNullOrEmpty(userInput.userinput)) return;

            await DataService.P_AddCategoryType(userInput.userinput);
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
            await DataService.P_AddOriginType(userInput.userinput);
            cb_init();
        }

        private void Set_Page()
        {
            int p_count = productsDatas.Count;

            //�q��page����
            int page = (int)Math.Floor(p_count / 8d);
            if (p_count % 8 != 0) page++;

            cbPage.Items.Clear();
            for (int i = 1; i <= page; i++)
                cbPage.Items.Add(i.ToString());

            //���UI�ƭ�
            if (cbPage.Items.Count != 0) cbPage.SelectedIndex = 0;
            lbPage.Text = $"/{page}��";
        }

        private void cbPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            setProductCardsDatas(cbPage.SelectedIndex + 1);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (cbPage.SelectedIndex != cbPage.Items.Count - 1)
                cbPage.SelectedIndex++;
        }

        private void btnBackPage_Click(object sender, EventArgs e)
        {
            if (cbPage.SelectedIndex != 0)
                cbPage.SelectedIndex--;
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

            //cbAddP_category.Items.AddRange(DataService.categorysDict.Select(o => o.Key).ToArray());
            //cbS_Category.Items.AddRange(DataService.categorysDict.Select(o => o.Key).ToArray());
            //cbAddP_origin.Items.AddRange(DataService.originsDict.Select(o => o.Key).ToArray());
            //cbS_Origin.Items.AddRange(DataService.originsDict.Select(o => o.Key).ToArray());
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

            await DataService.P_SelectProducts(productData, btnS_PriceToggle.Text == "�H�W", btnS_WeightToggle.Text == "�H�W");
            if (productsDatas.Count == 0) { MessageBox.Show("�d�L�����"); return; }
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
            await DataService.P_getProductCardsDatas();
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
            if (member == null)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.StartPosition = FormStartPosition.CenterParent;
                loginForm.LoginSuccess += LoginForMem_LoginSuccess;
                loginForm.ShowDialog();
            }
            else
            {
                //�n�X�\��
                member = null;
                flp_shoppingCar.Controls.Clear();
                orderDetail = [];
                btn_Login.Text = "���U/�n�J";
                lbMember.Text = string.Empty;
                ptb_Buy.Enabled = false;
                ptb_Buy.Visible = false;
                levelControl(3);
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

            getShoppingOrderID();
            orderDetail = await DataService.Odr_GetOrderDetail(member.OrderId);
            setShoppingCard(orderDetail);
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
            if (member == null) return;
            txbMem_Name.Text = member.Name;
            txbMem_Email.Text = member.Email;
            txbMem_Address.Text = member.Address;
            txbMem_Phone.Text = member.Phone;
        }

        private async void getShoppingOrderID()
        {
            if (member == null) return;
            int orderid = await DataService.Odr_GetMemberOrder(member.Id);
            if (orderid == 0)
            {
                await DataService.Odr_CreateNewOrder(Odr_getLatestOrderNum(), member.Id);
                orderid = await DataService.Odr_GetMemberOrder(member.Id);
            }
            member.OrderId = orderid;
        }

        private void btntest_Click_1(object sender, EventArgs e)
        {
            levelControl(2);
        }
        private int Odr_getLatestOrderNum()
        {
            return int.Parse(DateTime.Now.ToString("yy") + DateTime.Now.DayOfYear.ToString("D3") + nextOrderNum.ToString("0000"));
        }

        private async void Detail_PCard_OrderItemAdded(object? sender, KeyValuePair<int, int> e)
        {
            if (member == null) return;

            if (!orderDetail.ContainsKey(e.Key))
                await DataService.Odr_CreateOrderDetail(member.OrderId, e.Key, e.Value);
            else
                await DataService.Odr_UpdateOrderDetail(member.OrderId, e.Key, e.Value);

            orderDetail = await DataService.Odr_GetOrderDetail(member.OrderId);
            setShoppingCard(orderDetail);
        }

        private async void ShoppingCard_OrderItemChange(object? sender, KeyValuePair<int, int> e)
        {
            if (member == null) return;

            await DataService.Odr_UpdateOrderDetail(member.OrderId, e.Key, e.Value);
            orderDetail = await DataService.Odr_GetOrderDetail(member.OrderId);
            setShoppingCard(orderDetail);
        }

        private async void ShoppingCard_OrderItemDelete(object? sender, int e)
        {
            if (member == null) return;

            await DataService.Odr_DeleteOrderDetail(member.OrderId, e);
            orderDetail = await DataService.Odr_GetOrderDetail(member.OrderId);
            setShoppingCard(orderDetail);
        }

        private void setShoppingCard(Dictionary<int, int> orderDetail)
        {
            flp_shoppingCar.Controls.Clear();
            foreach (var item in orderDetail)
            {
                ShoppingCard shoppingCard = new ShoppingCard();
                ProductsData? productsData = productsDatas.FirstOrDefault(o => o.Id == item.Key);
                if (productsData == null) { MessageBox.Show($"��L�����ӫ~:{item.Key}�A�лP�J�A�pô"); continue; }
                shoppingCard.SetCard(productsData, item.Value);
                flp_shoppingCar.Controls.Add(shoppingCard);
            }
        }

        private void flp_shoppingCar_ControlChange(object sender, ControlEventArgs e)
        {
            FlowLayoutPanel? flowLayoutPanel = sender as FlowLayoutPanel;
            if (flowLayoutPanel == null) return;

            List<ShoppingCard> shoppingCards = flowLayoutPanel.Controls.OfType<ShoppingCard>().ToList();
            if (shoppingCards.Count == 0)
                txbTotal.Text = string.Empty;
            else txbTotal.Text = "�`���B:" + shoppingCards.Sum(o => o.total).ToString() + "$";

        }

        private async void ptb_Buy_Click(object sender, EventArgs e)
        {
            if (member == null) { MessageBox.Show("�Х��n�J�|��"); return; }
            if (orderDetail.Count == 0) { MessageBox.Show("�ʪ����ثe�O�ŪŪ�"); return; }

            PurchaseForm purchaseForm = new PurchaseForm();
            purchaseForm.StartPosition = FormStartPosition.CenterParent;
            purchaseForm.SetForm(member.OrderId);
            purchaseForm.ShowDialog();

            if (purchaseForm.DialogResult != DialogResult.OK) return;

            //�ק�q�檬�A
            if (await DataService.Odr_orderPlaced(member.OrderId, purchaseForm.payment, purchaseForm.OName,
                purchaseForm.OAddress, purchaseForm.RName, purchaseForm.RAddress))
            {
                MessageBox.Show("�q��U�榨�\");
                getShoppingOrderID();
                orderDetail = await DataService.Odr_GetOrderDetail(member.OrderId);
                setShoppingCard(orderDetail);
            }
        }

        private async void btnMemberEdit_Click(object sender, EventArgs e)
        {
            if (member == null) return;

            string emailPattern = @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
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
    }
}

