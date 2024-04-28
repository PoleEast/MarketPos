using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Data.SqlClient;

namespace MarketPos
{
    public partial class Form1 : Form
    {
        public static string Imgpath = @"../../../ProductsImg";
        private string ConnString =
            "Data Source=192.168.56.1,3453;Initial Catalog = dbMarketPos; User ID = MarkPosMan; Password=markpos;";
        private List<ProductCard> productCards = [];
        private List<ProductsData> productsDatas = [];
        private Dictionary<string, int> categorysDict = [];
        public Form1()
        {
            InitializeComponent();
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            //測試資料庫連接
            await DataService.ConnectionSql(ConnString);

            //抓取介面所有卡片
            productCards.Add(productCard1);
            productCards.Add(productCard2);
            productCards.Add(productCard3);
            productCards.Add(productCard4);
            productCards.Add(productCard5);
            productCards.Add(productCard6);
            productCards.Add(productCard7);
            productCards.Add(productCard8);

            getProductCardsData();
        }

        //獲取商品卡片
        private async void getProductCardsData()
        {
            productCards.ForEach(o => o.init());
            if (await DataService.ConnectionSql(ConnString))
            {
                using SqlConnection conn = new(ConnString);
                string sql = @"SELECT Products.name,Category.name AS  categoryName,price,shelveDate,description,weight,origin,stock
                                FROM Products
                                JOIN Category
                                ON Category.id=category";
                conn.Open();
                try
                {
                    using SqlCommand com = new(sql, conn);
                    using SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        ProductsData card = new()
                        {
                            Name = (string)reader["name"],
                            Category = (string)reader["categoryName"],
                            Description = (string)reader["description"],
                            Weight = (long)reader["weight"],
                            Price = (decimal)reader["price"],
                            ShelveDate = (DateTime)reader["shelveDate"],
                            Stock = (int)reader["stock"],
                            Origin = (string)reader["origin"]
                        };
                        setProductCardsData(card);
                    }
                }
                catch (Exception ex) { MessageBox.Show($"獲取商品資料發生錯誤\n {ex} "); }
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
            if (await DataService.ConnectionSql(ConnString))
            {
                
                using SqlConnection conn = new(ConnString);
                string sqlInsert = @"INSERT INTO Products([name],[category],[price],[description],[weight],[origin],[stock])
                                VALUES(@name,@category,@price,@description,@weight,@origin,@stock)";
                string sqlSelect = @"SELECT * ,category.name AS categoryName 
                                     FROM Products 
                                     JOIN Category
                                     ON Category.id=category
                                     WHERE Products.name=@name";
                conn.Open();
                using SqlCommand comInsert = new(sqlInsert, conn);
                try
                {
                    comInsert.Parameters.AddWithValue("@name", txbAddP_name.Text);
                    comInsert.Parameters.AddWithValue("@category", categorysDict[cbAddP_category.Text] );
                    comInsert.Parameters.AddWithValue("@price", txbAddP_price.Text);
                    comInsert.Parameters.AddWithValue("@description", rtbAddP_description.Text);
                    comInsert.Parameters.AddWithValue("@weight", txbAddP_weight.Text);
                    comInsert.Parameters.AddWithValue("@origin", txbAddP_origin.Text);
                    comInsert.Parameters.AddWithValue("@stock", cbAddP_stock.SelectedIndex);
                    //執行sql指令
                    comInsert.ExecuteNonQuery();

                    MessageBox.Show($"增加{txbAddP_name.Text}成功");
                    using SqlCommand comSelect = new(sqlSelect, conn);
                    comSelect.Parameters.AddWithValue("@name", txbAddP_name.Text);
                    SqlDataReader reader = comSelect.ExecuteReader();
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
                        Origin = (string)reader["origin"]
                    };
                    setProductCardsData(card);
                }
               
                catch (Exception ex) { MessageBox.Show($"資料庫寫入錯誤:\n {ex}"); }
            }
            
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            insertProduct();
        }

        private void cbAddP_stock_HandleCreated(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
                cbAddP_stock.Items.Add(i);
        }

        private async void cbAddP_category_HandleCreated(object sender, EventArgs e)
        {
            if (await DataService.ConnectionSql(ConnString))
            {
                categorysDict.Clear();
                using SqlConnection conn = new SqlConnection(ConnString);
                string sql = @"SELECT * FROM Category";
                conn.Open();
                try
                {
                    using SqlCommand com = new(sql, conn);
                    SqlDataReader reader = com.ExecuteReader();
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

        private async void btntest_Click(object sender, EventArgs e)
        {
            if (await DataService.ConnectionSql(ConnString))
            {
                string sqlSelect = @"SELECT * ,category.name AS categoryName 
                                     FROM Products 
                                     JOIN Category
                                     ON Category.id=category ";
                using SqlConnection conn = new(ConnString);
                conn.Open();
                try
                {
                    using SqlCommand comSelect = new(sqlSelect, conn);
                    comSelect.Parameters.AddWithValue("@name", txbAddP_name.Text);
                    SqlDataReader reader = comSelect.ExecuteReader();
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
                        Origin = (string)reader["origin"]
                    };
                    setProductCardsData(card);
                }
                catch (Exception ex) { MessageBox.Show($"資料庫寫入錯誤:\n {ex}"); }
            }
        }
    }
}
