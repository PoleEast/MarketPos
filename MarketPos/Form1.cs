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

namespace MarketPos
{
    public partial class Form1 : Form
    {
        public static string Imgpath = @"../../../ProductsImg";
        private static Member? member;
        public static List<ProductsData> productsDatas = [];
        private List<ProductCard> productCards = [];
        private int nextOrderNum;
        public Form1()
        {
            InitializeComponent();
            //int.Parse(DateTime.Now.ToString("yy") + DateTime.Now.DayOfYear + todayOrder.ToString("0000"));

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await DataService.P_getProductCardsDatas();

            //設定最新訂單編號 格式ex:"yydddoooo"
            string latestOrderNum = (await DataService.getLatestOrderNum()).ToString();

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

            //UI初始化用
            cb_Sort.SelectedIndex = 0;
            cb_Sort.SelectedIndexChanged += cb_Sort_SelectedIndexChanged;

            //暫時使用
            productSort("名稱", true);
            Set_Page();
            cb_init();
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
            int last = productsDatas.Count - first < 8 ? productsDatas.Count : first + uip_Count;

            //將商品顯示出來
            for (int i = first; i < last; i++)
                currentUI_Cards.Add(productsDatas[i]);
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
        /// true為desc,false為asce
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="mode"></param>
        public void productSort(string condition, bool mode)
        {
            if (condition == "名稱")
                productsDatas.Sort((a, b) => mode ? (mode ? -string.Compare(a.Name, b.Name) : string.Compare(a.Name, b.Name)) : 0);
            else if (condition == "種類")
                productsDatas.Sort((a, b) => mode ? (mode ? -a.Category.CompareTo(b.Category) : a.Category.CompareTo(b.Category)) : 0);
            else if (condition == "價格")
                productsDatas.Sort((a, b) => mode ? (mode ? -a.Price.CompareTo(b.Price) : a.Price.CompareTo(b.Price)) : 0);
            else if (condition == "重量")
                productsDatas.Sort((a, b) => mode ? (mode ? -a.Weight.CompareTo(b.Weight) : a.Weight.CompareTo(b.Weight)) : 0);
            else if (condition == "產地")
                productsDatas.Sort((a, b) => mode ? (mode ? -a.Origin.CompareTo(b.Origin) : a.Origin.CompareTo(b.Origin)) : 0);
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
        private void check_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
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

            await DataService.P_AddCategoryType(userInput.userinput);
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
            await DataService.P_AddOriginType(userInput.userinput);
            cb_init();
        }

        private void Set_Page()
        {
            int p_count = productsDatas.Count;

            //訂正page頁數
            int page = (int)Math.Floor(p_count / 8d);
            if (p_count % 8 != 0) page++;

            cbPage.Items.Clear();
            for (int i = 1; i <= page; i++)
                cbPage.Items.Add(i.ToString());

            //更改UI數值
            if (cbPage.Items.Count != 0) cbPage.SelectedIndex = 0;
            lbPage.Text = $"/{page}頁";
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

            cbAddP_category.Items.AddRange(DataService.categorysDict.Select(o => o.Key).ToArray());
            cbS_Category.Items.AddRange(DataService.categorysDict.Select(o => o.Key).ToArray());
            cbAddP_origin.Items.AddRange(DataService.originsDict.Select(o => o.Key).ToArray());
            cbS_Origin.Items.AddRange(DataService.originsDict.Select(o => o.Key).ToArray());
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

            await DataService.P_SelectProducts(productData, btnS_PriceToggle.Text == "以上", btnS_WeightToggle.Text == "以上");
            if (productsDatas.Count == 0) { MessageBox.Show("查無此資料"); return; }
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

        private void btnS_Clear_Click(object sender, EventArgs e)
        {
            txbS_Name.Text = "";
            txbS_Price.Text = "";
            txbS_weight.Text = "";
            cbS_Category.SelectedIndex = -1;
            cbS_Origin.SelectedIndex = -1;
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
                //登出功能
                member = null;
                btn_Login.Text = "註冊/登入";
            }
        }
        private void LoginForMem_LoginSuccess(object? sender, Member e)
        {
            if (sender == null) { MessageBox.Show("登入視窗為空"); return; }

            if (e.Id == 0) { MessageBox.Show("查無此用戶名稱"); return; };
            member = e;
            lbMember.Text = $"歡迎回來: {member.Name}";
            if (sender is LoginForm loginForm)
                loginForm.LoginSuccess -= LoginForMem_LoginSuccess;
            btn_Login.Text = "登出";
            getShoppingCard();
        }

        private async void getShoppingCard()
        {
            if (member == null) return;
            int id = await DataService.Mem_GetMemberShopping(member.Id);
            if (id == 0)
            {
                await DataService.Mem_CreateNewShopping(getlatestOrderNum(), member.Id);
                id = await DataService.Mem_GetMemberShopping(member.Id);
            }
        }

        private void btntest_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(getlatestOrderNum().ToString());
        }
        private int getlatestOrderNum()
        {
            return int.Parse(DateTime.Now.ToString("yy") + DateTime.Now.DayOfYear.ToString("D3") + nextOrderNum.ToString("0000"));
        }
    }
}

