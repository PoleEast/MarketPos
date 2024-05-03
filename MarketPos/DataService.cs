using Microsoft.SqlServer.Server;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
using System.Windows;

namespace MarketPos
{
    internal class DataService
    {
        public static Dictionary<string, int> categorysDict = [];
        public static Dictionary<string, int> originsDict = [];
        public static string ConnString =
        "Data Source=1.175.88.32,3453;Initial Catalog = dbMarketPos; User ID = MarkPosMan; Password=markpos;";
        private static async Task<bool> DS_ConnectionSql()
        {
            using SqlConnection conn = new(ConnString);
            try
            {
                await conn.OpenAsync();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("資料庫登入失敗 : \n" + ex.Message.ToString());
                return false;
            }
        }

        /// <summary>
        /// 獲取商品卡片
        /// </summary>
        public static async Task DS_getProductCardsDatas()
        {
            List<ProductsData> products = [];
            if (!await DS_ConnectionSql()) return;
            using SqlConnection conn = new(ConnString);
            string sql = @$"SELECT Products.id,Products.name,Category.name AS  categoryName,price,shelveDate,description,weight,origin.name AS originname,stock
                                FROM Products
                                JOIN Category ON Category.id=category
                                JOIN origin ON origin.id=origin
                                ORDER BY Products.id;";
            conn.Open();
            try
            {
                using SqlCommand com = new(sql, conn);
                await using SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    ProductsData card = new()
                    {
                        Id = reader.GetInt32("id"),
                        Name = (string)reader["name"],
                        Category = (string)reader["categoryName"],
                        Description = (string)reader["description"],
                        Weight = (long)reader["weight"],
                        Price = (decimal)reader["price"],
                        ShelveDate = (DateTime)reader["shelveDate"],
                        Stock = (int)reader["stock"],
                        Origin = (string)reader["originname"]
                    };
                    products.Add(card);
                }
                Form1.productsDatas = products;
            }
            catch (Exception ex) { MessageBox.Show($"獲取商品資料發生錯誤\n {ex} "); }
        }

        public static async void DS_insertProduct(ProductsData productsData)
        {
            if (!await DS_ConnectionSql()) return;
            using SqlConnection conn = new(ConnString);
            string sqlInsert = @"INSERT INTO Products([name],[category],[price],[description],[weight],[origin],[stock])
                                VALUES(@name,@category,@price,@description,@weight,@origin,@stock)";
            conn.Open();
            using SqlCommand comInsert = new(sqlInsert, conn);
            try
            {
                comInsert.Parameters.AddWithValue("@name", productsData.Name);
                comInsert.Parameters.AddWithValue("@category", categorysDict[productsData.Category]);
                comInsert.Parameters.AddWithValue("@price", productsData.Price);
                comInsert.Parameters.AddWithValue("@description", productsData.Description);
                comInsert.Parameters.AddWithValue("@weight", productsData.Weight);
                comInsert.Parameters.AddWithValue("@origin", originsDict[productsData.Origin]);
                comInsert.Parameters.AddWithValue("@stock", productsData.Stock);
                //執行sql指令
                comInsert.ExecuteNonQuery();

                MessageBox.Show($"增加{productsData.Name}成功");
            }

            catch (Exception ex) { MessageBox.Show($"資料庫寫入錯誤:\n {ex}"); }

        }

        /// <summary>
        /// priceOrder true為以上，false為以下
        /// weightOrder true為以上，false為以下
        /// </summary>
        /// <returns>查到的資料列表</returns>
        public static async Task DS_SelectProducts(ProductsData productsData, bool pricesort, bool weightsort)
        {
            List<ProductsData> productsDatas = [];
            if (!await DS_ConnectionSql()) return;
            string sqlSelect = @"SELECT * ,Category.name AS categoryName,Origin.name AS originName
                                FROM Products 
                                JOIN Category ON Category.id=category
                                JOIN Origin ON origin.id=origin 
                                WHERE 1=1";
            string priceSortString = pricesort ? ">=" : "<=";
            string weightSortStrng = weightsort ? ">=" : "<=";

            using SqlConnection conn = new(ConnString);
            using SqlCommand cmd = conn.CreateCommand();
            conn.Open();
            try
            {
                //設定搜尋字串
                if (!string.IsNullOrEmpty(productsData.Name))
                {
                    sqlSelect += " AND Products.name LIKE @Name ";
                    cmd.Parameters.AddWithValue("@name", $"%{productsData.Name}%");
                }
                if (!string.IsNullOrEmpty(productsData.Category))
                {
                    sqlSelect += " AND Category.name = @Category ";
                    cmd.Parameters.AddWithValue("@Category", productsData.Category);
                }
                if (productsData.Price > decimal.Zero)
                {
                    sqlSelect += $" AND Price {priceSortString} @Price ";
                    cmd.Parameters.AddWithValue("Price", productsData.Price);
                }
                if (productsData.Weight > 0.0)
                {
                    sqlSelect += $" AND Weight {weightSortStrng} @Weight ";
                    cmd.Parameters.AddWithValue("@Weight", productsData.Weight.ToString());
                }
                if (!string.IsNullOrEmpty(productsData.Origin))
                {
                    sqlSelect += " AND Origin.name = @Origin ";
                    cmd.Parameters.AddWithValue("@Origin", productsData.Origin);
                }

                cmd.Connection = conn;
                cmd.CommandText = sqlSelect;
                await using SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ProductsData data = new()
                    {
                        Id = (int)reader["id"],
                        Name = (string)reader["name"],
                        Category = (string)reader["categoryName"],
                        Description = (string)reader["description"],
                        Weight = (long)reader["weight"],
                        Price = (decimal)reader["price"],
                        ShelveDate = (DateTime)reader["shelveDate"],
                        Stock = (int)reader["stock"],
                        Origin = (string)reader["originName"]
                    };
                    productsDatas.Add(data);
                }
                Form1.productsDatas = productsDatas;
            }
            catch (Exception ex) { MessageBox.Show($"差尋錯誤:\n{ex}"); }
        }
        public static async Task DS_GetCategoryType()
        {
            if (!await DS_ConnectionSql()) return;
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

        }
        public static async Task DS_GetOriginType()
        {
            if (!await DS_ConnectionSql()) return;
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

        }

        public static async Task DS_AddCategoryType(string category)
        {
            if (!await DS_ConnectionSql()) return;

            using SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"INSERT INTO Category([name])VALUES(@category)";
            try
            {
                conn.Open();
                using SqlCommand com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("@category", category);
                com.ExecuteNonQuery();
                MessageBox.Show($"增加類別 {category} 成功");
            }
            catch (Exception ex) { MessageBox.Show($"資料庫寫入錯誤:\n {ex}"); }

        }

        public static async Task DS_AddOriginType(string origin)
        {
            if (!await DS_ConnectionSql()) return;

            using SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"INSERT INTO Origin([name])VALUES(@origin)";
            try
            {
                conn.Open();
                using SqlCommand com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("@origin", origin);
                com.ExecuteNonQuery();
                MessageBox.Show($"增加產地 {origin} 成功");
            }
            catch (Exception ex) { MessageBox.Show($"資料庫寫入錯誤:\n {ex}"); }
        }

        public static async Task<ProductsData?> DS_GetDetailProductCard(int productCard)
        {
            if (!await DS_ConnectionSql()) return null;

            using SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"SELECT * ,Category.name AS categoryName,Origin.name AS originName
                                FROM Products 
                                JOIN Category ON Category.id=category
                                JOIN Origin ON origin.id=origin 
                                WHERE Products.id=@id";
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("@id", productCard);

                SqlDataReader reader = com.ExecuteReader();
                reader.Read();
                ProductsData data = new()
                {
                    Id = (int)reader["id"],
                    Name = (string)reader["name"],
                    Category = (string)reader["categoryName"],
                    Description = (string)reader["description"],
                    Weight = (long)reader["weight"],
                    Price = (decimal)reader["price"],
                    ShelveDate = (DateTime)reader["shelveDate"],
                    Stock = (int)reader["stock"],
                    Origin = (string)reader["originName"]
                };
                return data;
            }
            catch (Exception ex) { MessageBox.Show($"商品詳細資料獲取失敗\n{ex}"); return null; }
        }
        public static string[] DS_GetPictures(string pathname)
        {
            var imgString = Form1.Imgpath + @"\" + pathname;
            if (Directory.Exists(imgString))
            {
                return Directory.GetFiles(imgString, "*.jpg");
            }
            return [];
        }
    }
}
