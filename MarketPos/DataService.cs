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
        "Data Source=1.175.113.56,3453;Initial Catalog = dbMarketPos; User ID = MarkPosMan; Password=markpos;";
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
        /// <param name="first"></param>
        /// <returns>從first列數到last之間的資料</returns>
        public static async Task<List<ProductsData>> DS_getProductCardsDatas(int first, int last)
        {
            List<ProductsData> products = [];
            if (!await DS_ConnectionSql()) return products;
            using SqlConnection conn = new(ConnString);
            string sql = @$"SELECT Products.name,Category.name AS  categoryName,price,shelveDate,description,weight,origin.name AS originname,stock
                                FROM Products
                                JOIN Category ON Category.id=category
                                JOIN origin ON origin.id=origin
                                ORDER BY Products.id
                                OFFSET {first} ROWS FETCH NEXT {last} ROWS ONLY";
            conn.Open();
            try
            {
                using SqlCommand com = new(sql, conn);
                await using SqlDataReader reader = com.ExecuteReader();
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
                        Origin = (string)reader["originname"]
                    };
                    products.Add(card);
                }
                return products;
            }
            catch (Exception ex) { MessageBox.Show($"獲取商品資料發生錯誤\n {ex} "); }

            return products;
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
        public static async Task<List<ProductsData>> DS_TSelectProducts(ProductsData productsData,bool pricesort, bool weightsort)
        {
            List<ProductsData> productsDatas = [];
            if (!await DS_ConnectionSql()) return productsDatas;
            string sqlSelect = @"SELECT * ,Category.name AS categoryName,Origin.name AS originName
                                FROM Products 
                                JOIN Category ON Category.id=category
                                JOIN Origin ON origin.id=origin 
                                WHERE 1=1";
            string priceSortString = pricesort ? ">=" : "<=";
            string weightSortStrng = weightsort ? ">=" : "<=";

            //舊版
            //switch (mode)
            //{
            //    //id
            //    case 1:
            //        if (keyword.GetType() != typeof(int)) return productsDatas;
            //        sqlSelect += @"WHERE Products.id=@keyword";
            //        break;
            //    //name
            //    case 2:
            //        if (keyword.GetType() != typeof(string)) return productsDatas;
            //        sqlSelect += @"WHERE Products.name=@keyword";
            //        break;
            //    default:
            //        return productsDatas;
            //}

            using SqlConnection conn = new(ConnString);
            conn.Open();
            using SqlCommand comInsert = new(sqlSelect, conn);
            try
            {
                if (string.IsNullOrEmpty(productsData.Name)) sqlSelect += "AND Products.name LIKE @Name";
                if (string.IsNullOrEmpty(productsData.Category)) sqlSelect += "AND categoryName = @Category";
                if (string.IsNullOrEmpty(productsData.Price.ToString())) sqlSelect += $"AND Price {priceSortString} @Price";
                if (string.IsNullOrEmpty(productsData.Weight.ToString())) sqlSelect += $"AND Weight {weightSortStrng} @Weight";
                if (string.IsNullOrEmpty(productsData.Origin)) sqlSelect += "AND originName = @Origin";
                using SqlCommand comSelect = new(sqlSelect, conn);
                comSelect.Parameters.AddWithValue("@keyword", keyword);
                await using SqlDataReader reader = comSelect.ExecuteReader();
                while (reader.Read())
                {
                    ProductsData data = new()
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
                    productsDatas.Add(data);
                }
                return productsDatas;
            }
            catch { return productsDatas; }
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

        /// <summary>
        /// </summary>
        /// <returns>查到的資料數量</returns>
        public static async Task<int> DS_GetProductCount(string categoryId)
        {
            string sql = @"SELECT COUNT(*) AS count FROM Products";
            if (!string.IsNullOrEmpty(categoryId))
            {
                sql += $@"WHERE category={categoryId}";
            }
            if (!await DS_ConnectionSql()) return 0;
            using SqlConnection conn = new SqlConnection(ConnString);
            try
            {
                conn.Open();
                using SqlCommand com = new SqlCommand(sql, conn);
                SqlDataReader reader = com.ExecuteReader();
                reader.Read();
                return (int)reader["count"];
            }
            catch (Exception ex) { MessageBox.Show($"資料庫頁數查詢錯誤\n {ex}"); return 0; }
        }
    }
}
