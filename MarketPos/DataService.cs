using Microsoft.SqlServer.Server;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
using System.Windows;

namespace MarketPos
{
    internal class DataService
    {
        private static async Task<bool> DS_TryDS_ConnectionSql(SqlConnection conn)
        {
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

        public static async Task<bool> DS_ConnectionSql(string connString)
        {
            using SqlConnection conn = new(connString);
            return await DS_TryDS_ConnectionSql(conn);
        }

        //獲取商品卡片
        public static async Task<List<ProductsData>> DS_getProductCardsData(int first)
        {
            List<ProductsData> products = [];
            if (await DataService.DS_ConnectionSql(Form1.ConnString))
            {
                using SqlConnection conn = new(Form1.ConnString);
                string sql = @$"SELECT Products.name,Category.name AS  categoryName,price,shelveDate,description,weight,origin.name AS originname,stock
                                FROM Products
                                JOIN Category ON Category.id=category
                                JOIN origin ON origin.id=origin
                                ORDER BY Products.id
                                OFFSET {first} ROWS FETCH NEXT 8 ROWS ONLY";
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
                            Origin = (string)reader["originname"]
                        };
                        products.Add(card);
                    }
                    return products;
                }
                catch (Exception ex) { MessageBox.Show($"獲取商品資料發生錯誤\n {ex} "); }
            }
            return products;
        }

        public async void DS_insertProduct()
        {
            if (await DataService.DS_ConnectionSql(Form1.ConnString))
            {

                using SqlConnection conn = new(Form1.ConnString);
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
    }
}
