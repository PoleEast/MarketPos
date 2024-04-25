using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Data.SqlClient;

namespace MarketPos
{
    public partial class Form1 : Form
    {
        public static string Imgpath = @"C:\Users\iSpan\Desktop\Code\MarketPos\MarketPos\ProductsImg";
        private string ConnString =
            "Data Source=1.175.66.209,3453;Initial Catalog = dbMarketPos; User ID = MarkPosMan; Password=markpos;";
        private List<ProductCard> productCards = new List<ProductCard>();
        private List<ProductsData> productsDatas = new List<ProductsData>();
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
        private async void getProductCardsData()
        {
            if (await DataService.ConnectionSql(ConnString))
            {
                SqlConnection conn = new SqlConnection(ConnString);
                string sql = @"SELECT Products.name,Category.name AS  categoryName,price,shelveDate,description,weight,origin,stock
                                FROM Products
                                JOIN Category
                                ON Category.id=category";
                conn.Open();
                var com = new SqlCommand(sql, conn);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    ProductsData card = new ProductsData();
                    card.Name = (string)reader["name"];
                    card.Category = (string)reader["categoryName"];
                    card.Description = (string)reader["description"];
                    card.Weight = (long)reader["weight"];
                    card.Price = (decimal)reader["price"];
                    card.ShelveDate = (DateTime)reader["shelveDate"];
                    card.Stock = (int)reader["stock"];
                    card.Origin = (string)reader["origin"];

                    var productCard = productCards.FirstOrDefault(o => o.Visible == false);
                    if (productCard != null) { productCard.SetCard(card); }
                }

            }
        }
    }
}
