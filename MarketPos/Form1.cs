using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace MarketPos
{
    public partial class Form1 : Form
    {
        public static string Imgpath = @"../../../ProductsImg";
        private List<ProductCard> productCards = [];
        private List<ProductsData> productsDatas = [];
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
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
            setProductCardsDatas(1);

            //暫時使用
            Set_Page();
            cb_init();
        }

        /// <summary>
        /// 依照頁面商品數量來獲取資料並顯示出來
        /// </summary>
        private async void setProductCardsDatas(int page)
        {
            int uip_Count = productCards.Count;
            int first = uip_Count * page - uip_Count;
            productCards.ForEach(o => o.init());
            List<ProductsData> products = await DataService.DS_getProductCardsDatas(first, uip_Count);
            foreach (ProductsData product in products)
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
            DataService.DS_insertProduct(productData);
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

        private void btntest_Click(object sender, EventArgs e)
        {

        }

        //限制輸入為數字
        private void check_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private async void cbAddCategoryType_Click(object sender, EventArgs e)
        {
            UserInput userInput = new("請輸入新增的類別:")
            {
                StartPosition = FormStartPosition.CenterParent
            };

            //輸入確認
            if (userInput.ShowDialog(this) == DialogResult.Cancel) return;
            if (string.IsNullOrEmpty(userInput.userinput)) return;

            await DataService.DS_AddCategoryType(userInput.userinput);
            cb_init();
        }

        private async void btnAddOriginType_Click(object sender, EventArgs e)
        {
            UserInput userInput = new("請輸入新增的產地:")
            {
                StartPosition = FormStartPosition.CenterParent
            };

            //輸入確認
            if (userInput.ShowDialog(this) == DialogResult.Cancel) return;
            if (string.IsNullOrEmpty(userInput.userinput)) return;

            //將新類別輸入資料庫
            await DataService.DS_AddOriginType(userInput.userinput);
            cb_init();
        }

        private async void Set_Page()
        {
            int p_count = await DataService.DS_GetProductCount("");

            //訂正page頁數
            int page = (int)Math.Floor(p_count / 8d);
            if (p_count % 8 != 0) page++;

            cbPage.Items.Clear();
            for (int i = 1; i <= page; i++)
                cbPage.Items.Add(i.ToString());

            //更改UI數值
            cbPage.SelectedIndex = 0;
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
            await DataService.DS_GetCategoryType();
            await DataService.DS_GetOriginType();
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
                productData.Name = txbAddP_name.Text.Trim();
                productData.Category = cbS_Category.Text;
                productData.Price = Decimal.Parse(txbS_Price.Text.Trim());
                productData.Weight = double.Parse(txbS_weight.Text.Trim());
                productData.Origin = cbS_Origin.Text;
            }
            catch(Exception ex) { MessageBox.Show($"輸入錯誤{ex}");return; }

            await DataService.DS_TSelectProducts(productData);
        }

        private void btnS_PriceUp_Click(object sender, EventArgs e)
        {
            btnS_PriceDown.Enabled = true;
            btnS_PriceUp.Enabled = false;
        }
        private void btnS_PriceDown_Click(object sender, EventArgs e)
        {
            btnS_PriceUp.Enabled = true;
            btnS_PriceDown.Enabled = false;       
        }

        private void btnS_WeightUp_Click(object sender, EventArgs e)
        {
            btnS_WeightDown.Enabled = true;
            btnS_WeightUp.Enabled = false;
        }

        private void btnS_WeightDown_Click(object sender, EventArgs e)
        {
            btnS_WeightUp.Enabled = true;
            btnS_WeightDown.Enabled = false;
        }
    }
}

