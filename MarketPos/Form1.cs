using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Globalization;

namespace MarketPos
{
    public partial class Form1 : Form
    {
        public static string Imgpath = @"../../../ProductsImg";
        public static string ConnString =
            "Data Source=1.175.113.56,3453;Initial Catalog = dbMarketPos; User ID = MarkPosMan; Password=markpos;";
        private List<ProductCard> productCards = [];
        private List<ProductsData> productsDatas = [];
        private Dictionary<string, int> categorysDict = [];
        private Dictionary<string, int> originsDict = [];
        public Form1()
        {
            InitializeComponent();
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            //測試資料庫連接
            await DataService.DS_ConnectionSql(ConnString);

            //抓取介面所有卡片
            productCards.Add(productCard1);
            productCards.Add(productCard2);
            productCards.Add(productCard3);
            productCards.Add(productCard4);
            productCards.Add(productCard5);
            productCards.Add(productCard6);
            productCards.Add(productCard7);
            productCards.Add(productCard8);

            getProductCardsData(1);
        }

        private async void setcbPage()
        {
            
        }

        //獲取商品卡片
        private async void getProductCardsData(int page)
        {
            int first = 8 * page - 8;
            productCards.ForEach(o => o.init());
            List<ProductsData> products = await DataService.DS_getProductCardsData(first);
            foreach (ProductsData product in products)
            {
                setProductCardsData(product);
            }
        }

        //將資料填入還空缺的卡片
        private void setProductCardsData(ProductsData productsData)
        {
            var productCard = productCards.FirstOrDefault(o => o.Visible == false);
            productCard?.SetCard(productsData);
        }

        private async void insertProduct()
        {
            if (await DataService.DS_ConnectionSql(ConnString))
            {

                using SqlConnection conn = new(ConnString);
                string sqlInsert = @"INSERT INTO Products([name],[category],[price],[description],[weight],[origin],[stock])
                                VALUES(@name,@category,@price,@description,@weight,@origin,@stock)";
                string sqlSelect = @"SELECT * ,Category.name AS categoryName,Origin.name AS originName
                                     FROM Products 
                                     JOIN Category ON Category.id=category
                                     JOIN Origin ON origin.id=origin
                                     WHERE Products.name=@name";
                conn.Open();
                using SqlCommand comInsert = new(sqlInsert, conn);
                try
                {
                    comInsert.Parameters.AddWithValue("@name", txbAddP_name.Text.Trim());
                    comInsert.Parameters.AddWithValue("@category", categorysDict[cbAddP_category.Text]);
                    comInsert.Parameters.AddWithValue("@price", txbAddP_price.Text.Trim());
                    comInsert.Parameters.AddWithValue("@description", rtbAddP_description.Text);
                    comInsert.Parameters.AddWithValue("@weight", txbAddP_weight.Text);
                    comInsert.Parameters.AddWithValue("@origin", originsDict[cbAddP_origin.Text]);
                    comInsert.Parameters.AddWithValue("@stock", cbAddP_stock.SelectedIndex);
                    //執行sql指令
                    comInsert.ExecuteNonQuery();

                    MessageBox.Show($"增加{txbAddP_name.Text}成功");
                    using SqlCommand comSelect = new(sqlSelect, conn);
                    comSelect.Parameters.AddWithValue("@name", txbAddP_name.Text);
                    using SqlDataReader reader = comSelect.ExecuteReader();
                    reader.Read();
                    ProductsData card = new()
                    {
                        Name = (string)reader["name"],
                        Category = (string)reader["categoryName"],
                        Description = (string)reader["description"],
                        Weight = (long)reader["weight"],
                        Price = (decimal)reader["price"],
                        ShelveDate = (DateTime)reader["shelveDate"],
                        Stock = (int)reader["stock"],
                        Origin = (string)reader["originName"]
                    };
                    setProductCardsData(card);
                }

                catch (Exception ex) { MessageBox.Show($"資料庫寫入錯誤:\n {ex}"); }
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

        private void cbAddP_stock_HandleCreated(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
                cbAddP_stock.Items.Add(i);
        }

        private async void cbAddP_category_HandleCreated(object sender, EventArgs e)
        {
            if (await DataService.DS_ConnectionSql(ConnString))
            {
                categorysDict.Clear();
                using SqlConnection conn = new SqlConnection(ConnString);
                string sql = @"SELECT * FROM Category";
                conn.Open();
                try
                {
                    using SqlCommand com = new(sql, conn);
                    using SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        categorysDict.Add((string)reader["name"], (int)reader["id"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"cbt獲取商品類型錯誤\n{ex}");
                }
                cbAddP_category.Items.AddRange(categorysDict.Select(o => o.Key).ToArray());
            }
        }
        private async void cbAddP_origin_HandleCreated(object sender, EventArgs e)
        {
            if (await DataService.DS_ConnectionSql(ConnString))
            {
                originsDict.Clear();
                using SqlConnection conn = new SqlConnection(ConnString);
                string sql = @"SELECT * FROM Origin";
                conn.Open();
                try
                {
                    using SqlCommand com = new(sql, conn);
                    using SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        originsDict.Add((string)reader["name"], (int)reader["id"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"cbt獲取商品產地錯誤\n{ex}");
                }
                cbAddP_origin.Items.AddRange(originsDict.Select(o => o.Key).ToArray());
            }
        }

        private void btntest_Click(object sender, EventArgs e)
        {
        }

        private void txbAddP_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txbAddP_name.TextLength > 5)
            {
                e.Handled = true;
            }
        }

        private void txbAddP_price_KeyPress(object sender, KeyPressEventArgs e)
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

            //將新類別輸入資料庫
            if (await DataService.DS_ConnectionSql(ConnString))
            {
                using SqlConnection conn = new SqlConnection(ConnString);
                string sql = @"INSERT INTO Category([name])VALUES(@category)";
                try
                {
                    conn.Open();
                    using SqlCommand com = new SqlCommand(sql, conn);
                    com.Parameters.AddWithValue("@category", userInput.userinput);
                    com.ExecuteNonQuery();
                    MessageBox.Show($"增加類別 {userInput.userinput} 成功");
                }
                catch (Exception ex) { MessageBox.Show($"資料庫寫入錯誤:\n {ex}"); }
            }
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
            if (await DataService.DS_ConnectionSql(ConnString))
            {
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    string sql = @"INSERT INTO Origin([name])VALUES(@origin)";
                    try
                    {
                        conn.Open();
                        using SqlCommand com = new SqlCommand(sql, conn);
                        com.Parameters.AddWithValue("@origin", userInput.userinput);
                        com.ExecuteNonQuery();
                        MessageBox.Show($"增加產地 {userInput.userinput} 成功");
                    }
                    catch (Exception ex) { MessageBox.Show($"資料庫寫入錯誤:\n {ex}"); }
                }
            }
        }
    }
}
