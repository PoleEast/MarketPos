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

        //key是id,value是數量
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

            //設定最新訂單編號 格式ex:"yydddoooo"
            string latestOrderNum = (await DataService.Odr_getLatestOrderNum()).ToString();

            nextOrderNum = latestOrderNum.Substring(0, 5) == DateTime.Now.ToString("yy") + DateTime.Now.DayOfYear.ToString("D3") ?
                int.Parse(latestOrderNum) - (int.Parse(DateTime.Now.ToString("yy") + DateTime.Now.DayOfYear.ToString("D3") + "0000")) + 1 : 1;

            //抓取介面所有卡片
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

            //UI初始化用
            cb_Sort.SelectedIndex = 0;
            cb_Sort.SelectedIndexChanged += cb_Sort_SelectedIndexChanged;
            Detail_PCard.OrderItemAdded += Detail_PCard_OrderItemAdded;
            ShoppingCard.OrderItemChange += ShoppingCard_OrderItemChange;
            ShoppingCard.OrderItemDelete += ShoppingCard_OrderItemDelete;
            ShoppingCard.ConfirmedChange += ShoppingCard_ConfirmedChange;
            Mem_Detail_PCard.ChangeProduct += Mem_Detail_PCard_ChangeProduct;

            tabPagesControl = tbcControl.TabPages.Cast<TabPage>().ToList();
            tabPagesProduct = tbcProdut.TabPages.Cast<TabPage>().ToList();

            //權限功能初始化
            levelControl(4);

            //暫時使用
            productSort("名稱", true);
            Set_Page();
            cb_init();
        }

        private void getProductCardsDatas(List<ProductsData> datas)
        {
            shelveProducts = datas.Where(o => o.IsShelve).ToList();
            unshelveProducts = datas.Where(o => !o.IsShelve).ToList();
        }

        //新增tab後請到這裡設定權限
        private void levelControl(int level)
        {
#pragma warning disable CS8604 // 可能有 Null 參考引數。

            tbcControl.TabPages.Clear();
            tbcProdut.TabPages.Clear();

            try
            {
                //訪客權限
                if (level <= 4)
                {
                    tbcControl.TabPages.Add(tabPagesControl.FirstOrDefault(o => o.Name == "tbMemSerch"));
                    tbcProdut.TabPages.Add(tabPagesProduct.FirstOrDefault(o => o.Name == "tbProduct"));
                }
                //會員權限
                if (level == 3)
                {
                    tbcControl.TabPages.Add(tabPagesControl.FirstOrDefault(o => o.Name == "tbMenberEdit"));
                    tbcControl.TabPages.Add(tabPagesControl.FirstOrDefault(o => o.Name == "tbOrderHistory"));
                }
                //管理員權限
                if (level <= 2)
                {
                    tbcProdut.TabPages.Add(tabPagesProduct.FirstOrDefault(o => o.Name == "tbUnshelve"));
                    tbcControl.TabPages.Add(tabPagesControl.FirstOrDefault(o => o.Name == "tbAddProduct"));
                    tbcControl.TabPages.Add(tabPagesControl.FirstOrDefault(o => o.Name == "tbManOrder"));
                }
                //系統最高管理員
                if (level == 1)
                {
                }
            }
            catch { MessageBox.Show("出現重大錯誤權限分割"); }
#pragma warning disable CS8604 // 可能有 Null 參考引數。
        }

        /// <summary>
        /// 依照頁面商品數量來獲取資料並顯示出來
        /// </summary>
        private void setProductCardsDatas(int page)
        {
            List<ProductsData> currentUI_Cards = [];

            productCards.ForEach(o => o.init());

            //計算需要哪個區間的商品
            int uip_Count = productCards.Count;
            int first = uip_Count * page - uip_Count;
            int last = shelveProducts.Count - first < 8 ? shelveProducts.Count : first + uip_Count;

            //將商品顯示出來
            for (int i = first; i < last; i++)
                currentUI_Cards.Add(shelveProducts[i]);


            foreach (ProductsData product in currentUI_Cards)
            {
                setProductCardsData(product);
            }
        }

        /// <summary>
        /// 將資料填入還空缺的卡片
        /// </summary>
        private void setProductCardsData(ProductsData productsData)
        {
            var productCard = productCards.FirstOrDefault(o => o.ProductID == 0);
            productCard?.SetCard(productsData);
        }

        private void setUnShelveCardsDatas(int page)
        {
            //管理者功能
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
        /// true為desc,false為asce
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="mode"></param>
        public void productSort(string condition, bool mode)
        {
            if (condition == "名稱")
                shelveProducts.Sort((a, b) => mode ? -string.Compare(a.Name, b.Name) : string.Compare(a.Name, b.Name));
            else if (condition == "種類")
                shelveProducts.Sort((a, b) => mode ? -a.Category.CompareTo(b.Category) : a.Category.CompareTo(b.Category));
            else if (condition == "價格")
                shelveProducts.Sort((a, b) => mode ? -a.Price.CompareTo(b.Price) : a.Price.CompareTo(b.Price));
            else if (condition == "重量")
                shelveProducts.Sort((a, b) => mode ? -a.Weight.CompareTo(b.Weight) : a.Weight.CompareTo(b.Weight));
            else if (condition == "產地")
                shelveProducts.Sort((a, b) => mode ? -a.Origin.CompareTo(b.Origin) : a.Origin.CompareTo(b.Origin));
            else
            {
                MessageBox.Show("商品排序出現錯誤");
                return;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //確認使用者有無輸入數值
            if (string.IsNullOrEmpty(txbAddP_name.Text) ||
                string.IsNullOrEmpty(txbAddP_price.Text) ||
                string.IsNullOrEmpty(txbAddP_weight.Text))
            { MessageBox.Show("請輸入正確的欄位格式"); return; }

            //確認使用者有無選擇數值
            if (cbAddP_origin.SelectedIndex == -1 ||
                cbAddP_stock.SelectedIndex == -1 ||
                cbAddP_category.SelectedIndex == -1)
            { MessageBox.Show("請選擇正確的選單"); return; }

            //使用者確認資料
            DialogResult result = MessageBox.Show($"確認要增加商品:\n名稱:{txbAddP_name.Text}\n種類:{cbAddP_category.Text}\n" +
                $"價格:{txbAddP_price.Text}\n重量:{txbAddP_weight.Text}\n產地:{cbAddP_origin.Text}\n" +
                $"庫存:{cbAddP_stock.Text}", "確認", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel) return;

            insertProduct();
        }

        //限制輸入為數字
        private void checkNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        //限制輸入為密碼
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
            UserInputForm userInput = new("請輸入新增的類別:")
            {
                StartPosition = FormStartPosition.CenterParent
            };

            //輸入確認
            if (userInput.ShowDialog(this) == DialogResult.Cancel) return;
            if (string.IsNullOrEmpty(userInput.userinput)) return;

            await DataService.MP_AddCategoryType(userInput.userinput);
            cb_init();
        }

        private async void btnAddOriginType_Click(object sender, EventArgs e)
        {
            UserInputForm userInput = new("請輸入新增的產地:")
            {
                StartPosition = FormStartPosition.CenterParent
            };

            //輸入確認
            if (userInput.ShowDialog(this) == DialogResult.Cancel) return;
            if (string.IsNullOrEmpty(userInput.userinput)) return;

            //將新類別輸入資料庫
            await DataService.MP_AddOriginType(userInput.userinput);
            cb_init();
        }

        private void Set_Page()
        {
            int p_count = shelveProducts.Count;

            //訂正page頁數
            int page = (int)Math.Floor(p_count / 8d);
            if (p_count % 8 != 0) page++;

            cbPage.Items.Clear();
            for (int i = 1; i <= page; i++)
                cbPage.Items.Add(i.ToString());

            //更改UI數值
            if (cbPage.Items.Count != 0) cbPage.SelectedIndex = 0;
            lbPage.Text = $"/{page}頁";


            //管理者功能
            if (member == null) return;
            if (member.Level > 2) return;
            int unp_count = unshelveProducts.Count;

            //訂正page頁數
            page = (int)Math.Floor(unp_count / 8d);
            if (unp_count % 8 != 0) page++;

            cbUnPage.Items.Clear();
            for (int i = 1; i <= page; i++)
                cbUnPage.Items.Add(i.ToString());

            //更改UI數值
            if (cbUnPage.Items.Count != 0) cbUnPage.SelectedIndex = 0;
            lbUnPage.Text = $"/{page}頁";
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

        //將資料填入cb
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
            catch (Exception ex) { MessageBox.Show($"輸入錯誤{ex}"); return; }

            var data = await DataService.P_SelectProducts(productData, btnS_PriceToggle.Text == "以上", btnS_WeightToggle.Text == "以上");
            if (data.Where(o => o.IsShelve).Count() == 0 && member.Level < 3) { MessageBox.Show("查無此資料"); return; }
            getProductCardsDatas(data);
            if (ptb_Sort.Tag == null)
            {
                MessageBox.Show("找不到ptb_Sort.tag");
                return;
            }
            productSort("名稱", ptb_Sort.Tag.ToString() == "descendingOrder");
            Set_Page();

        }

        private void btnS_WeightToggle_Click(object sender, EventArgs e)
        {
            if (btnS_WeightToggle.Text == "以上")
                btnS_WeightToggle.Text = "以下";
            else if (btnS_WeightToggle.Text == "以下")
                btnS_WeightToggle.Text = "以上";
        }

        private void btnS_PriceToggle_Click(object sender, EventArgs e)
        {
            if (btnS_PriceToggle.Text == "以上")
                btnS_PriceToggle.Text = "以下";
            else if (btnS_PriceToggle.Text == "以下")
                btnS_PriceToggle.Text = "以上";
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
                MessageBox.Show("找不到ptb_Sort.tag");
                return;
            }
            productSort("名稱", ptb_Sort.Tag.ToString() == "descendingOrder");
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
                //登出功能
                member = new Member();
                flp_shoppingCar.Controls.Clear();
                orderDetails = [];
                btn_Login.Text = "註冊/登入";
                lbMember.Text = string.Empty;
                ptb_Buy.Enabled = false;
                ptb_Buy.Visible = false;
                levelControl(4);
            }
            btnS_Clear_Click(this, EventArgs.Empty);
        }
        private async void LoginForMem_LoginSuccess(object? sender, Member e)
        {
            if (sender == null) { MessageBox.Show("登入視窗為空"); return; }
            if (e.Id == 0) { MessageBox.Show("查無此用戶名稱"); return; };

            member = e;

            //UI設置
            ptb_Buy.Enabled = true;
            ptb_Buy.Visible = true;
            levelControl(member.Level);
            setMemberProfile(false);

            //會員訂單處理
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
        /// 如需重新抓取會員資料請傳入true
        /// </summary>
        private async void setMemberProfile(bool mode)
        {
            if (member == null || member.Id == 0) return;
            if (mode) member = await DataService.Mem_Login(member.Account, member.HashPassword);

            lbMember.Text = $"歡迎回來: {member.Name}";
            btn_Login.Text = "登出";
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
                MessageBox.Show("找不到ptb_Sort.tag");
                return;
            }
            productSort("名稱", ptb_Sort.Tag.ToString() == "descendingOrder");
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

        /// <param name="orderDetail">訂單詳細資料</param>
        /// <param name="flp">設置的版面</param>
        private void setShoppingCard(List<OrderDetail> orderDetail, FlowLayoutPanel flp, bool isShoppingCar)
        {
            flp.Controls.Clear();
            foreach (var item in orderDetail)
            {
                ShoppingCard shoppingCard = new ShoppingCard(isShoppingCar);
                List<ProductsData> datas = [.. unshelveProducts, .. shelveProducts];

                ProductsData? productsData = datas.FirstOrDefault(o => o.Id == item.productID && (o.IsShelve || !isShoppingCar));

                if (productsData == null) { MessageBox.Show($"找無此筆商品:{item.productID}，請與克服聯繫"); continue; }
                shoppingCard.SetCard(productsData, item);
                flp.Controls.Add(shoppingCard);
            }
        }

        /// <summary>
        /// 計算總金額
        /// </summary>
        private void flp_ControlChange(object sender, EventArgs e)
        {
            FlowLayoutPanel? flowLayoutPanel = sender as FlowLayoutPanel;
            if (flowLayoutPanel == null) return;

            //選擇要將金額輸出在哪個txb
            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
            if (flowLayoutPanel.Name == "flp_shoppingCar") textBox = txbTotal;
            else if (flowLayoutPanel.Name == "flpOdr_Histroy") textBox = txbOdr_Total;
            else if (flowLayoutPanel.Name == "flpMOdr") textBox = txbMOdr_Total;

            List<ShoppingCard> shoppingCards = flowLayoutPanel.Controls.OfType<ShoppingCard>().ToList();
            if (shoppingCards.Count == 0)
                textBox.Text = string.Empty;
            else textBox.Text = "總金額:" + shoppingCards.Sum(o => o.total).ToString() + "$";
        }

        private async void ptb_Buy_Click(object sender, EventArgs e)
        {
            if (member == null || member.Id == 0) { MessageBox.Show("請先登入會員"); return; }
            if (orderDetails.Count == 0) { MessageBox.Show("購物車目前是空空的"); return; }

            PurchaseForm purchaseForm = new PurchaseForm();
            purchaseForm.StartPosition = FormStartPosition.CenterParent;
            purchaseForm.SetForm(member.OrderId);
            purchaseForm.ShowDialog();

            if (purchaseForm.DialogResult != DialogResult.OK) return;

            //修改訂單狀態
            if (await DataService.Odr_orderPlaced(member.OrderId, purchaseForm.payment, purchaseForm.OName,
                purchaseForm.OAddress, purchaseForm.RName, purchaseForm.RAddress, orderDetails))
            {
                MessageBox.Show("訂單下單成功");

                //初始化訂單
                getShoppingOrderID();
                orderDetails = await DataService.Odr_GetOrderDetail(member.OrderId);
                setShoppingCard(orderDetails, flp_shoppingCar, true);

                //重新獲取商品資料
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

            if (string.IsNullOrEmpty(txbMem_Name.Text)) { MessageBox.Show("請填入要更改的名字"); return; }
            if (!string.IsNullOrEmpty(txbMem_Email.Text) && !Regex.IsMatch(txbMem_Email.Text, emailPattern))
            { MessageBox.Show("請填入正確的MAIL地址"); return; }
            if (!Regex.IsMatch(txbMem_Phone.Text, phonePattern) && !string.IsNullOrEmpty(txbMem_Phone.Text))
            { MessageBox.Show("請填入正確的手機號碼"); return; }

            if (!await DataService.Mem_EditProfile(txbMem_Name.Text.Trim(), txbMem_Address.Text.Trim(),
                    txbMem_Email.Text.Trim(), txbMem_Phone.Text, member.Id))
                return;

            MessageBox.Show("會員基本資料更新成功");
            setMemberProfile(true);
        }

        private async void btnAccountEdit_Click(object sender, EventArgs e)
        {
            if (member == null || member.Id == 0) return;

            string oldPassword = txbOldPassword.Text.Trim();
            string newPassword = txbPassword.Text.Trim();
            string check = txbCheck.Text.Trim();
            List<string> list = [oldPassword, newPassword, check];

            if (list.Any(string.IsNullOrEmpty)) { MessageBox.Show("請輸入新舊密碼"); return; }
            if (!newPassword.Equals(check)) { MessageBox.Show("密碼輸入不一致"); return; }
            if (newPassword.Length < 6) { MessageBox.Show("請輸入正確的密碼格式，請大於6個英文數字"); return; }


            string oldSaltStr = await DataService.Mem_LoginGetSalt(member.Account);
            byte[] oldSalt = Convert.FromBase64String(oldSaltStr);
            byte[] oldHashpassword = GHashPassword(oldPassword, oldSalt);
            string oldHashpasswordStr = Convert.ToBase64String(oldHashpassword);
            if (member.HashPassword != oldHashpasswordStr) { MessageBox.Show("舊密碼登入錯誤"); return; }

            //密碼加密
            byte[] newSalt = CreateSalt();
            string newSaltStr = Convert.ToBase64String(newSalt);
            byte[] newHashpassword = GHashPassword(newPassword, newSalt);
            string newHashpasswordStr = Convert.ToBase64String(newHashpassword);

            if (await DataService.Mem_EditAccount(newHashpasswordStr, newSaltStr, member.Account))
            {
                member = await DataService.Mem_Login(member.Account, newHashpasswordStr);
                if (member == null || member.Id == 0) MessageBox.Show("出現錯誤請與克服聯繫");
                MessageBox.Show("密碼更改成功");
                txbOldPassword.Text = string.Empty;
                txbPassword.Text = string.Empty;
                txbCheck.Text = string.Empty;
            }
        }

        //產生鹽巴
        public static byte[] CreateSalt()
        {
            byte[] buffer = new byte[16];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(buffer);
            return buffer;
        }

        //hash來源https://ithelp.ithome.com.tw/articles/10266660
        public static byte[] GHashPassword(string password, byte[] salt)
        {
            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password));
            argon2.Salt = salt;
            argon2.DegreeOfParallelism = 4; // 4 核心就設成 8
            argon2.Iterations = 3; // 迭代運算次數
            argon2.MemorySize = 512 * 512;

            return argon2.GetBytes(16);
        }

        private void lb_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.Label? label = sender as System.Windows.Forms.Label;
            if (label == null) return;

            // 計算文字寬度和標籤寬度的比例
            int minFontSize = 6;
            if (string.IsNullOrEmpty(label.Text)) return;
            float ratio = 200f / TextRenderer.MeasureText(label.Text, label.Font).Width;

            // 如果比例小於1，調整字體大小
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
            lbOdr_date.Text = "訂購日期 : " + orderData.PlacedDate.ToString("yyyy年MM月dd日");
            lbOdr_Payment.Text = "付款方式 : " + paymentmethod[orderData.Payment];
            lbOdr_OName.Text = "訂購人姓名 :" + orderData.OrdererName;
            txbOdr_OAdress.Text = orderData.OrdererAddress;
            lbOdr_RName.Text = "收貨人姓名 :" + orderData.ReceiverName;
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
            lbMOdr_Date.Text = "訂購日期 : " + orderData.PlacedDate.ToString("yyyy年MM月dd日");
            lbMOdr_Payment.Text = "付款方式 : " + paymentmethod[orderData.Payment];
            lbMOdr_OName.Text = "訂購人姓名 :" + orderData.OrdererName;
            txbMOdr_OAddress.Text = orderData.OrdererAddress;
            lbMOdr_RName.Text = "收貨人姓名 :" + orderData.ReceiverName;
            txbMOdr_RAddress.Text = orderData.ReceiverAddress;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

