using Microsoft.SqlServer.Server;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Net.Http;
using System.Transactions;
using System.Windows;

namespace MarketPos
{
    internal class DataService
    {
        public static Dictionary<string, int> categorysDict = [];
        public static Dictionary<string, int> originsDict = [];
        public static string ConnString =
        "Data Source=1.175.87.203,3453;Initial Catalog = dbMarketPos; User ID = MarkPosMan; Password=markpos;";
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

        //------------------------------------------------------------------------------------------
        //以下為sql商品相關功能

        /// <summary>
        /// 獲取商品卡片
        /// </summary>
        public static async Task P_getProductCardsDatas()
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

        public static async void P_insertProduct(ProductsData productsData)
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
        public static async Task P_SelectProducts(ProductsData productsData, bool pricesort, bool weightsort)
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
        public static async Task P_GetCategoryType()
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
        public static async Task P_GetOriginType()
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

        public static async Task P_AddCategoryType(string category)
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

        public static async Task P_AddOriginType(string origin)
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

        public static string[] DS_GetPictures(string pathname)
        {
            var imgString = Form1.Imgpath + @"\" + pathname;
            if (Directory.Exists(imgString))
            {
                return Directory.GetFiles(imgString, "*.jpg");
            }
            return [];
        }

        //------------------------------------------------------------------------------------------
        //以下為會員相關sql功能

        public static async Task MeMem_GetMemberName(string hashPassword, string salt, string name, string account)
        {
            if (!await DS_ConnectionSql()) return;
            using SqlConnection conn = new SqlConnection(ConnString);
            string sqlAccount = @"INSERT INTO Account(account,[password],salt)
                          VALUES(@account,@password,@salt);
                          SELECT SCOPE_IDENTITY();";
            int accountid = 0;

            string sqlMember = @"INSERT INTO Member(name,account)
                                 VALUES(@name,@account)";
            conn.Open();
            using SqlTransaction transaction = conn.BeginTransaction();
            using (SqlCommand com = new SqlCommand(sqlAccount, conn, transaction))
            {
                try
                {

                    //建立帳號密碼
                    com.Parameters.AddWithValue("@account", account);
                    com.Parameters.AddWithValue("@password", hashPassword);
                    com.Parameters.AddWithValue("@salt", salt);
                    accountid = Convert.ToInt32(com.ExecuteScalar());

                    //建立會員資料
                    com.CommandText = sqlMember;
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@name", name);
                    com.Parameters.AddWithValue("@account", accountid);
                    com.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show($"歡迎加入會員{name}");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"帳號創建失敗\n{ex}");
                    return;
                }
            }

        }
        public static async Task<string> MeMem_LoginGetSalt(string account)
        {
            if (!await DS_ConnectionSql()) return "";
            using SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"SELECT salt
                           FROM Account
                           WHERE account=@account";
            using SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@account", account);
            try
            {
                conn.Open();
                using SqlDataReader reader = com.ExecuteReader();
                if (!reader.HasRows) return "";
                reader.Read();
                return (string)reader["salt"];
            }
            catch (Exception ex) { MessageBox.Show($"獲取資料庫資源錯誤\n{ex}"); return ""; }
        }
        public static async Task<Member> Mem_Login(string account, string password)
        {
            Member member = new Member();
            if (!await DS_ConnectionSql()) return member;
            using SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"SELECT Account.account,name,Member.id as ID, Account.password as password
                           FROM Account
                           JOIN [Member]
                           ON [Member].account=Account.id
                           WHERE Account.account=@account AND Account.password=@password";
            using SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@account", account);
            com.Parameters.AddWithValue("@password", password);
            try
            {
                conn.Open();
                using SqlDataReader reader = com.ExecuteReader();
                if (!reader.HasRows) return member;
                reader.Read();
                member.Id = (int)reader["id"];
                member.Name = (string)reader["name"];
                member.Account = (string)reader["account"];
                member.HashPassword = (string)reader["password"];
                return member;
            }
            catch (Exception ex) { MessageBox.Show($"驗證會員發生錯誤\n{ex}"); return member; }
        }

        //---------------------------------------------------------------------
        //以下為訂單相關功能

        /// <summary></summary>
        /// <returns>回傳-1為sql錯誤 回傳0為查不到訂單</returns>
        public static async Task<int> Odr_GetMemberOrder(int id)
        {
            if (!await DS_ConnectionSql()) return -1;
            using SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"SELECT Orders.id as id
                           FROM Member
                           JOIN Orders
                           ON Member.id=Orders.memberID
                           WHERE Member.id=@id AND Orders.isPaid=0";
            using SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@id", id);
            try
            {
                conn.Open();
                using SqlDataReader reader = com.ExecuteReader();
                if (!reader.HasRows) return 0;
                reader.Read();
                return (int)reader["id"];
            }
            catch (Exception ex) { MessageBox.Show($"訂單獲取失敗{ex}"); return -1; };
        }

        /// <summary></summary>
        /// <returns>回傳-1為sql錯誤 回傳0為查不到訂單</returns>
        /// 
        public static async Task<int> Odr_getLatestOrderNum()
        {
            if (!await DS_ConnectionSql()) return -1;
            using SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"SELECT MAX(id) AS id
                           FROM Orders";
            SqlCommand com = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                using SqlDataReader reader = com.ExecuteReader();
                if (!reader.HasRows) return -1;
                reader.Read();
                return (int)reader["id"];
            }
            catch (Exception ex) { MessageBox.Show($"獲取最新訂單編號失敗\n{ex}"); return -1; }
        }

        public static async Task Odr_CreateNewOrder(int orderID, int memberid)
        {
            if (!await DS_ConnectionSql()) return;
            using SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"INSERT INTO Orders(id,memberID)
                           VALUES(@id,@memberID)";
            using SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@id", orderID);
            com.Parameters.AddWithValue("@memberID", memberid);
            try
            {
                conn.Open();
                com.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show($"創建新購物清單失敗\n{ex}"); return; }
        }

        public static async Task Odr_CreateOrderDetail(int orderid, int productid, int quantity)
        {
            if (!await DS_ConnectionSql()) return;
            using SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"INSERT INTO OrderDetails(orderID,productID,quantity)
                           VALUES(@orderID,@productID,@quantity)";
            SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@orderID", orderid);
            com.Parameters.AddWithValue("@productID", productid);
            com.Parameters.AddWithValue("@quantity", quantity);
            try
            {
                conn.Open();
                com.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show($"創建訂單明細失敗\n{ex}"); return; }
        }

        public static async Task<Dictionary<int, int>> Odr_GetOrderDetail(int orderid)
        {
            Dictionary<int, int> orderDetail = [];
            if (!await DS_ConnectionSql()) return orderDetail;
            using SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"SELECT productID,quantity
                           FROM OrderDetails
                           WHERE orderID=@orderid";
            SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@orderid", orderid);
            try
            {
                conn.Open();
                using SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    orderDetail.Add((int)reader["productID"], (int)reader["quantity"]);
                }
                return orderDetail;
            }
            catch (Exception ex) { MessageBox.Show($"獲取商品詳細清單錯誤\n{ex}"); return []; }
        }
    }
}
