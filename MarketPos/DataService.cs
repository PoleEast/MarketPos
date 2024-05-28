using MarketPos.Models;
using Microsoft.SqlServer.Server;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Net.Http;
using System.Numerics;
using System.Text;
using System.Transactions;
using System.Web;
using System.Windows;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MarketPos
{
    internal class DataService
    {
        public static Dictionary<string, int> categorysDict = [];
        public static Dictionary<string, int> originsDict = [];
        public static Dictionary<string, int> payDict = [];
        public static string ConnString = string.Empty;
        private static async Task<bool> DS_ConnectionSql()
        {
            if (ConnString == string.Empty)
            {
                string filePath = @"../../../connString.txt";
                try
                {
                    ConnString = File.ReadAllText(filePath);
                }
                catch
                {
                    MessageBox.Show("請設定好資料庫連接字串");
                }
            }
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
        public static async Task<List<ProductsData>> P_getProductCardsDatas()
        {
            List<ProductsData> products = [];
            if (!await DS_ConnectionSql()) return products;
            using SqlConnection conn = new(ConnString);
            string sql = @$"SELECT Products.id,Products.name,Category.name AS  categoryName,price,shelveDate,description,weight,origin.name AS originname,stock,isShelve
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
                        Origin = (string)reader["originname"],
                        IsShelve = (bool)reader["isShelve"]
                    };
                    products.Add(card);
                }
                return products;
            }
            catch (Exception ex) { MessageBox.Show($"獲取商品資料發生錯誤\n {ex} "); return products; }
        }

        /// <summary>
        /// priceOrder true為以上，false為以下
        /// weightOrder true為以上，false為以下
        /// </summary>
        /// <returns>查到的資料列表</returns>
        public static async Task<List<ProductsData>> P_SelectProducts(ProductsData productsData, bool pricesort, bool weightsort)
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
                    cmd.Parameters.AddWithValue("@Price", productsData.Price);
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
                        Origin = (string)reader["originName"],
                        IsShelve = (bool)reader["isShelve"]
                    };
                    productsDatas.Add(data);
                }
                return productsDatas;
            }
            catch (Exception ex) { MessageBox.Show($"差尋錯誤:\n{ex}"); return productsDatas; }
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
        //以下是商品管理相關

        public static async Task<bool> MP_UpdateProduct(ProductsData productsData)
        {
            if (!await DS_ConnectionSql()) return false;
            using SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"UPDATE Products SET ";
            List<string> sqlUpdate = [];
            using SqlCommand com = new SqlCommand();
            if (!string.IsNullOrEmpty(productsData.Name))
            {
                sqlUpdate.Add("name=@Name");
                com.Parameters.AddWithValue("@Name", productsData.Name);
            }
            if (!string.IsNullOrEmpty(productsData.Description))
            {
                sqlUpdate.Add("description=@Description");
                com.Parameters.AddWithValue("@Description", productsData.Description);
            }
            if (!string.IsNullOrEmpty(productsData.Category))
            {
                sqlUpdate.Add("category=@Category");
                com.Parameters.AddWithValue("@Category", categorysDict[productsData.Category]);
            }
            if (!string.IsNullOrEmpty(productsData.Origin))
            {
                sqlUpdate.Add("origin=@Origin");
                com.Parameters.AddWithValue("@Origin", originsDict[productsData.Origin]);
            }
            if (Math.Floor(productsData.Price) != 0)
            {
                sqlUpdate.Add("price=@Price");
                com.Parameters.AddWithValue("@Price", productsData.Price);
            }
            if (Math.Floor(productsData.Weight) != 0)
            {
                sqlUpdate.Add("weight=@Weight");
                com.Parameters.AddWithValue("@Weight", productsData.Weight);
            }
            sqlUpdate.Add("stock=@Stock");
            sqlUpdate.Add("isShelve=@IsShelve");
            sql += (string.Join(", ", sqlUpdate));
            sql += @" WHERE id=@ID";
            com.Parameters.AddWithValue("@Stock", productsData.Stock);
            com.Parameters.AddWithValue("@IsShelve", productsData.IsShelve);
            com.Parameters.AddWithValue("@ID", productsData.Id);
            try
            {
                conn.Open();
                com.Connection = conn;
                com.CommandText = sql;
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex) { MessageBox.Show($"商品更新失敗\n{ex}"); return false; }

        }

        public static async void MP_insertProduct(ProductsData productsData)
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

        public static async Task MP_AddOriginType(string origin)
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

        public static async Task MP_AddCategoryType(string category)
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

        //------------------------------------------------------------------------------------------
        //以下為會員相關sql功能

        public static async Task Mem_CreatetMemberName(string hashPassword, string salt, string name, string account, int level)
        {
            if (!await DS_ConnectionSql()) return;
            using SqlConnection conn = new SqlConnection(ConnString);
            string sqlAccount = @"INSERT INTO Account(account,[password],salt)
                          VALUES(@account,@password,@salt);
                          SELECT SCOPE_IDENTITY();";
            int accountid = 0;

            string sqlMember = @"INSERT INTO Member(name,account,level)
                                 VALUES(@name,@account,@level)";
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
                    com.Parameters.AddWithValue("@level", level);
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
        public static async Task<string> Mem_LoginGetSalt(string account)
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
            string sql = @"SELECT * ,Member.id as ID
                           FROM Account
                           JOIN [Member]
                           ON [Member].account=Account.id
                           WHERE Account.account=@account COLLATE Latin1_General_BIN
                           AND Account.password=@password COLLATE Latin1_General_BIN";

            using SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@account", account);
            com.Parameters.AddWithValue("@password", password);
            try
            {
                conn.Open();
                using SqlDataReader reader = com.ExecuteReader();
                if (!reader.HasRows) return member;
                reader.Read();
                member.Id = (int)reader["ID"];
                member.Name = (string)reader["name"];
                member.Account = (string)reader["account"];
                member.HashPassword = (string)reader["password"];
                member.Level = (int)reader["level"];
                member.Email = reader["email"] != DBNull.Value ? (string)reader["email"] : string.Empty;
                member.Phone = reader["phone"] != DBNull.Value ? (string)reader["phone"] : string.Empty;
                member.Address = reader["address"] != DBNull.Value ? (string)reader["address"] : string.Empty; ;
                return member;
            }
            catch (Exception ex) { MessageBox.Show($"驗證會員發生錯誤\n{ex}"); return member; }
        }

        public static async Task<List<Member>> Mem_SearchId(string keyword)
        {
            List<Member> members = new List<Member>();
            if (!await DS_ConnectionSql()) return members;
            using SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"SELECT * FROM Member WHERE name LIKE @keyword";

            using SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            try
            {
                conn.Open();
                using SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Member member = new()
                    {
                        Id = (int)reader["ID"],
                        Name = (string)reader["name"],
                        Level = (int)reader["level"],
                        Email = reader["email"] != DBNull.Value ? (string)reader["email"] : string.Empty,
                        Phone = reader["phone"] != DBNull.Value ? (string)reader["phone"] : string.Empty,
                        Address = reader["address"] != DBNull.Value ? (string)reader["address"] : string.Empty
                    };
                    members.Add(member);
                }
                return members;
            }
            catch (Exception ex) { MessageBox.Show($"驗證會員發生錯誤\n{ex}"); return members; }
        }


        public static async Task<bool> Mem_EditProfile(string name, string address, string email, string phone, int id)
        {
            if (!await DS_ConnectionSql()) return false;
            using SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"UPDATE Member
                           SET address=@address,email=@email,name=@name,phone=@phone
                           WHERE Member.id=@id";
            using SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@name", name);
            com.Parameters.AddWithValue("@address", address);
            com.Parameters.AddWithValue("@email", email);
            com.Parameters.AddWithValue("@phone", phone);
            com.Parameters.AddWithValue("@id", id);
            try
            {
                conn.Open();
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex) { MessageBox.Show($"會員基本資料更新失敗\n{ex}"); return false; }
        }

        public static async Task<bool> Mem_EditAccount(string newHashPassword, string newSaltl, string account)
        {
            if (!await DS_ConnectionSql()) return false;
            using SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"UPDATE Account
                           SET password=@newHashPassword,salt=@newSaltl
                           WHERE account=@account";
            using SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@newHashPassword", newHashPassword);
            com.Parameters.AddWithValue("@newSaltl", newSaltl);
            com.Parameters.AddWithValue("@account", account);
            try
            {
                conn.Open();
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex) { MessageBox.Show($"密碼更改發生錯誤\n{ex}"); return false; }
        }

        //---------------------------------------------------------------------
        //以下為訂單相關功能

        /// <summary></summary>
        /// <returns>回傳-1為sql錯誤 回傳0為查不到訂單</returns>
        public static async Task<int> Odr_GetMemberOrderID(int id)
        {
            if (!await DS_ConnectionSql()) return -1;
            using SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"SELECT Orders.id as id
                           FROM Member
                           JOIN Orders
                           ON Member.id=Orders.memberID
                           WHERE Member.id=@id AND Orders.placed=0";
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
            if (!await DS_ConnectionSql()) return 23000000;
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

        public static async Task Odr_CreateOrderDetail(OrderDetail orderDetail)
        {
            if (!await DS_ConnectionSql()) return;
            using SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"INSERT INTO OrderDetails(orderID,productID,quantity)
                           VALUES(@orderID,@productID,@quantity)";
            SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@orderID", orderDetail.orderID);
            com.Parameters.AddWithValue("@productID", orderDetail.productID);
            com.Parameters.AddWithValue("@quantity", orderDetail.quantity);
            try
            {
                conn.Open();
                com.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show($"創建訂單明細失敗\n{ex}"); return; }
        }


        /// <returns>Dictionary key=產品ID value=數量</returns>
        public static async Task<List<OrderDetail>> Odr_GetOrderDetail(int orderid)
        {
            List<OrderDetail> orderDetails = [];
            if (!await DS_ConnectionSql()) return orderDetails;
            using SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"SELECT productID,quantity,confirmed,orderID
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
                    OrderDetail orderDetail = new OrderDetail();
                    orderDetail.productID = (int)reader["productID"];
                    orderDetail.quantity = (int)reader["quantity"];
                    orderDetail.orderID = (int)reader["orderID"];
                    orderDetail.confirmed = (bool)reader["confirmed"];

                    orderDetails.Add(orderDetail);
                }
                return orderDetails;
            }
            catch (Exception ex) { MessageBox.Show($"獲取商品詳細清單錯誤\n{ex}"); return []; }
        }

        public static async Task Odr_UpdateOrderDetail(OrderDetail orderDetail)
        {
            if (!await DS_ConnectionSql()) { return; }
            using SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"UPDATE OrderDetails 
                           SET quantity = @quantity,confirmed = @confirmed
                           WHERE orderID = @orderid AND productID=@productid";
            SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@orderid", orderDetail.orderID);
            com.Parameters.AddWithValue("@productid", orderDetail.productID);
            com.Parameters.AddWithValue("@quantity", orderDetail.quantity);
            com.Parameters.AddWithValue("@confirmed", orderDetail.confirmed);
            try
            {
                conn.Open();
                com.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show($"訂單商品數量更新失敗\n{ex}"); return; }
        }

        public static async Task Odr_DeleteOrderDetail(int orderid, int productid)
        {
            if (!await DS_ConnectionSql()) { return; }
            using SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"DELETE FROM OrderDetails 
                           WHERE orderID=@orderid AND productID=@productid";
            SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@orderid", orderid);
            com.Parameters.AddWithValue("@productid", productid);
            try
            {
                conn.Open();
                com.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show($"訂單商品刪除失敗\n{ex}"); return; }
        }

        public static async Task Odr_GetPayment()
        {
            payDict.Clear();
            if (!await DS_ConnectionSql()) return;
            using SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"SELECT * FROM [PaymentMethods]";
            SqlCommand com = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                    payDict.Add((string)reader["name"], (int)reader["id"]);
                return;
            }
            catch (Exception ex) { MessageBox.Show($"獲取付款方式失敗\n{ex}"); return; }
        }

        public static async Task<bool> Odr_orderPlaced(int orderid, int paymentMethodID, string ordererName, string ordererAddress,
            string receiverName, string receiverAddress, List<OrderDetail> orderDetails)
        {
            if (!await DS_ConnectionSql()) return false;
            using SqlConnection conn = new SqlConnection(ConnString);
            string sqlOrder = @"UPDATE Orders
                           SET placed=@placed,paymentMethodID=@paymentMethodID,
                               [ordererName]=@ordererName,[ordererAddress]=@ordererAddress,
                               [receiverName]=@receiverName,[receiverAddress]=@receiverAddress,
                               [placedDate]=GETDATE()
                           WHERE id=@orderid";
            string sqlStock = @"UPDATE Products SET stock=@stock WHERE id=@id";

            conn.Open();
            using SqlTransaction trans = conn.BeginTransaction();
            using SqlCommand com = new SqlCommand(sqlOrder, conn, trans);
            {
                try
                {
                    //更新訂單狀態
                    com.Parameters.AddWithValue("@placed", 1);
                    com.Parameters.AddWithValue("@paymentMethodID", paymentMethodID);
                    com.Parameters.AddWithValue("@ordererName", ordererName);
                    com.Parameters.AddWithValue("@ordererAddress", ordererAddress);
                    com.Parameters.AddWithValue("@receiverName", receiverName);
                    com.Parameters.AddWithValue("@receiverAddress", receiverAddress);
                    com.Parameters.AddWithValue("@orderid", orderid);
                    com.ExecuteNonQuery();

                    com.CommandText = sqlStock;
                    //修改庫存數目
                    foreach (var item in orderDetails)
                    {
                        com.Parameters.Clear();

                        var product = Form1.shelveProducts.First(o => o.Id == item.productID);
                        int stock = product.Stock - item.quantity;
                        if (stock < 0) throw new Exception();

                        com.Parameters.AddWithValue("@id", item.productID);
                        com.Parameters.AddWithValue("@stock", stock);
                        com.ExecuteNonQuery();
                    }

                    trans.Commit();
                    return true;
                }

                catch (Exception ex) { trans.Rollback(); ; MessageBox.Show($"訂單狀態確認下單失敗\n{ex}"); return false; }
            }
        }

        public static async Task Odr_UpdateConfirmed(bool confirmed, int orderid)
        {
            if (!await DS_ConnectionSql()) return;
            using SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"UPDATE Orders SET confirmed=@confirmed WHERE id=@id";
            SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@confirmed", confirmed);
            com.Parameters.AddWithValue("@id", orderid);
            try
            {
                conn.Open();
                com.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show($"訂單確認狀態更新失敗\n{ex}"); return; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">id傳入0代表為管理者</param>
        /// <returns></returns>
        public static async Task<List<int>> Odr_getHistoryNum(int id)
        {
            List<int> orderNums = [];
            if (!await DS_ConnectionSql()) return orderNums;
            using SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"SELECT id FROM Orders WHERE 1=1 AND placed = 1 ";
            using SqlCommand com = new SqlCommand();
            if (id != 0)
            {
                sql += @"AND memberID=@id ";
                com.Parameters.AddWithValue("@id", id);
            }
            sql += @"ORDER BY confirmed ASC, id DESC";
            try
            {
                conn.Open();
                com.CommandText = sql;
                com.Connection = conn;
                using SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                    orderNums.Add((int)reader["id"]);

                return orderNums;
            }
            catch (Exception ex) { MessageBox.Show($"獲取歷史訂單編號失敗\n{ex}"); return []; }
        }

        public static async Task<Order> Odr_GetOrderData(int orderid)
        {
            Order order = new Order();
            if (!await DS_ConnectionSql()) return order;
            using SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"SELECT * FROM Orders WHERE id=@orderid AND placed = 1";
            using SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@orderid", orderid);
            try
            {
                conn.Open();
                using SqlDataReader reader = com.ExecuteReader();
                if (!reader.HasRows) return order;

                reader.Read();
                order.MemberId = (int)reader["memberID"];
                order.OrdererName = (string)reader["ordererName"];
                order.OrdererAddress = (string)reader["ordererAddress"];
                order.ReceiverName = (string)reader["receiverName"];
                order.ReceiverAddress = (string)reader["receiverAddress"];
                order.Payment = (int)reader["paymentMethodID"];
                order.PlacedDate = (DateTime)reader["placedDate"];
                order.Comment = (string)reader["comment"];
                order.Confirmed = (bool)reader["confirmed"];
                order.isCancel = (bool)reader["isCancel"];
                order.isRead = (bool)reader["isRead"];

                return order;
            }
            catch (Exception ex) { MessageBox.Show($"獲取歷史訂單資料失敗\n{ex}"); return order; }
        }

        public static async Task<bool> Odr_ConfirmedChange(OrderDetail orderDetail)
        {
            if (!await DS_ConnectionSql()) return false;
            using SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"UPDATE INTO Orders SET confirmed=@confirmed WHERE id=@orderid";
            using SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@confirmed", orderDetail.confirmed);
            com.Parameters.AddWithValue("@id", orderDetail.orderID);
            try
            {
                conn.Open();
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex) { MessageBox.Show($"訂單確認狀態更改失敗\n{ex}"); return false; };
        }
        public static async Task Odr_SetMessage(int orderid, string comment, bool isRead)
        {
            if (!await DS_ConnectionSql()) return;
            using SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"UPDATE Orders SET comment=@comment,isRead=@isRead WHERE id=@orderid";
            SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@orderid", orderid);
            com.Parameters.AddWithValue("@comment", comment);
            com.Parameters.AddWithValue("@isRead", isRead);
            try
            {
                conn.Open();
                com.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show($"更新訂單訊息失敗{ex}"); }
        }

        public static async Task<List<Order>> Odr_GetUnreadMessage(int memberid)
        {
            List<Order> orders = new List<Order>();
            if (!await DS_ConnectionSql()) return orders;
            using SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"SELECT id,comment FROM Orders WHERE memberID=@memberid AND isRead=0";
            SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@memberid", memberid);
            try
            {
                conn.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Order order = new();
                    order.Id = (int)reader["id"];
                    order.Comment = (string)reader["comment"];

                    orders.Add(order);
                }
                return orders;
            }
            catch (Exception ex) { MessageBox.Show($"訂單訊息獲取失敗\n{ex}"); return []; }
        }

        public static async Task<bool> Odr_SetOrderCancel(int orderid, bool isCancel)
        {
            if (!await DS_ConnectionSql()) return false;
            SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"UPDATE Orders SET isCancel=@isCancel WHERE id=@orderid";
            SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@isCancel", isCancel);
            com.Parameters.AddWithValue("@orderid", orderid);
            try
            {
                conn.Open();
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex) { MessageBox.Show($"更改訂單取消狀態失敗\n{ex}"); return false; }
        }

        /// <summary>
        /// quantitysort true為以上，false為以下
        /// </summary>
        /// <returns>查到的資料列表</returns>
        public static async Task<List<OrderDetail>> Odr_SelectOrderDetails(OrderDetail orderDetail, bool? quantitysort = null, bool? isconfirmed = null)
        {
            List<OrderDetail> orderDetails = [];
            if (!await DS_ConnectionSql()) return orderDetails;
            string sqlSelect = @"SELECT * FROM OrderDetails WHERE 1=1";

            string quantitysortString = string.Empty;
            if (quantitysort.HasValue)
                quantitysortString = (bool)quantitysort ? ">=" : "<=";

            using SqlConnection conn = new(ConnString);
            using SqlCommand cmd = conn.CreateCommand();
            conn.Open();
            try
            {
                //設定搜尋字串
                if (orderDetail.productID != 0)
                {
                    sqlSelect += " AND productID=@productID ";
                    cmd.Parameters.AddWithValue("@productID", orderDetail.productID);
                }
                if (orderDetail.quantity > 0)
                {
                    sqlSelect += $" AND quantity {quantitysortString} @quantity";
                    cmd.Parameters.AddWithValue("@quantity", orderDetail.quantity);
                }
                if (isconfirmed.HasValue)
                {
                    sqlSelect += $" AND confirmed=@confirmed ";
                    cmd.Parameters.AddWithValue("@confirmed", isconfirmed);
                }

                cmd.Connection = conn;
                cmd.CommandText = sqlSelect;
                await using SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    OrderDetail data = new()
                    {
                        orderID = (int)reader["orderID"],
                        productID = (int)reader["productID"],
                        quantity = (int)reader["quantity"],
                        confirmed = (bool)reader["confirmed"]
                    };
                    orderDetails.Add(data);
                }
                return orderDetails;
            }
            catch (Exception ex) { MessageBox.Show($"查尋訂單細節錯誤:\n{ex}"); return orderDetails; }
        }
        public static async Task<List<Order>> Odr_SelectOrders
            (Order order, DateTime? starttime = null, DateTime? endtime = null, bool? isCancel = null, bool? isConfirmed = null, bool? isRead = null)
        {
            List<Order> Orders = [];
            if (!await DS_ConnectionSql()) return Orders;
            string sqlSelect = @"SELECT * FROM Orders WHERE 1=1 AND placed=1";
            using SqlConnection conn = new(ConnString);
            using SqlCommand cmd = conn.CreateCommand();
            conn.Open();
            try
            {
                //設定搜尋字串
                if (order.Id > 0)
                {
                    sqlSelect += " AND id=@orderid ";
                    cmd.Parameters.AddWithValue("@orderid", order.Id);
                }
                if (order.MemberId > 0)
                {
                    sqlSelect += " AND memberID=@memberID ";
                    cmd.Parameters.AddWithValue("@memberID", order.MemberId);
                }
                if (starttime.HasValue)
                {
                    sqlSelect += $" AND placedDate>=@starttime ";
                    cmd.Parameters.AddWithValue("@starttime", starttime);
                }
                if (endtime.HasValue)
                {
                    sqlSelect += $" AND placedDate<=@endtime ";
                    cmd.Parameters.AddWithValue("@endtime", endtime);
                }
                if (isCancel.HasValue)
                {
                    sqlSelect += $" AND isCancel=@isCancel ";
                    cmd.Parameters.AddWithValue("@isCancel", isCancel);
                }
                if (isConfirmed.HasValue)
                {
                    sqlSelect += $" AND confirmed=@confirmed ";
                    cmd.Parameters.AddWithValue("@confirmed", isConfirmed);
                }
                if (isRead.HasValue)
                {
                    sqlSelect += $" AND isRead=@isRead ";
                    cmd.Parameters.AddWithValue("@isRead", isRead);
                }
                if (order.Payment > 0)
                {
                    sqlSelect += " AND paymentMethodID=@payment ";
                    cmd.Parameters.AddWithValue("@payment", order.Payment);
                }
                if (!string.IsNullOrEmpty(order.OrdererAddress))
                {
                    sqlSelect += " AND ordererAddress LIKE '%@OrdererAddress%' ";
                    cmd.Parameters.AddWithValue("@OrdererAddress", order.OrdererAddress);
                }
                if (!string.IsNullOrEmpty(order.OrdererName))
                {
                    sqlSelect += " AND ordererName LIKE '%@OrdererName%' ";
                    cmd.Parameters.AddWithValue("@OrdererName", order.OrdererName);
                }
                if (!string.IsNullOrEmpty(order.ReceiverAddress))
                {
                    sqlSelect += " AND receiverAddress LIKE '%@ReceiverAddress%' ";
                    cmd.Parameters.AddWithValue("@ReceiverAddress", order.ReceiverAddress);
                }
                if (!string.IsNullOrEmpty(order.ReceiverName))
                {
                    sqlSelect += " AND receiverName LIKE '%@ReceiverName%' ";
                    cmd.Parameters.AddWithValue("@ReceiverName", order.ReceiverName);
                }

                cmd.Connection = conn;
                cmd.CommandText = sqlSelect;
                await using SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Order data = new()
                    {
                        Id = (int)reader["id"],
                        MemberId = (int)reader["memberID"],
                        OrdererName = (string)reader["ordererName"],
                        OrdererAddress = (string)reader["ordererAddress"],
                        ReceiverName = (string)reader["receiverName"],
                        ReceiverAddress = (string)reader["receiverAddress"],
                        Payment = (int)reader["paymentMethodID"],
                        PlacedDate = (DateTime)reader["placedDate"],
                        Comment = (string)reader["comment"],
                        Confirmed = (bool)reader["confirmed"],
                        isCancel = (bool)reader["isCancel"],
                        isRead = (bool)reader["isRead"]
                    };
                    Orders.Add(data);
                }
                return Orders;
            }
            catch (Exception ex) { MessageBox.Show($"查尋訂單細節錯誤:\n{ex}"); return Orders; }
        }

        //銷售資料表用
        public static async Task<List<(int, int)>> SALE_GetMemberQuantity()
        {
            List<(int, int)> results = new List<(int, int)>();

            if (!await DS_ConnectionSql()) return results;
            SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"SELECT memberID, SUM(OrderDetails.quantity) as YAxis FROM OrderDetails
                          JOIN Orders ON OrderDetails.orderID=Orders.id
                          GROUP BY Orders.memberID
                          ORDER BY SUM(OrderDetails.quantity) DESC";
            SqlCommand com = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                await using SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    (int, int) result = new();
                    result.Item1 = (int)reader["memberID"];
                    result.Item2 = (int)reader["YAxis"];

                    results.Add(result);
                }
                return results;
            }
            catch (Exception ex) { MessageBox.Show($"獲取會員銷售數量失敗\n{ex}"); return results; }
        }

        public static async Task<List<(int, int)>> SALE_productQuantity()
        {
            List<(int, int)> results = new List<(int, int)>();

            if (!await DS_ConnectionSql()) return results;
            SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"SELECT productID as Xaxis,SUM(OrderDetails.quantity) as YAxis
                            FROM OrderDetails
                            GROUP BY OrderDetails.productID
                            ORDER BY SUM(OrderDetails.quantity) DESC";
            SqlCommand com = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                await using SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    (int, int) result = new();
                    result.Item1 = (int)reader["Xaxis"];
                    result.Item2 = (int)reader["YAxis"];

                    results.Add(result);
                }
                return results;
            }
            catch (Exception ex) { MessageBox.Show($"獲取商品銷售數量失敗\n{ex}"); return results; }
        }

        public static async Task<List<(int, int)>> SALE_GetMemberSaleTotal()
        {
            List<(int, int)> results = new List<(int, int)>();

            if (!await DS_ConnectionSql()) return results;
            SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"SELECT memberID as Xaxis, SUM(OrderDetails.quantity) as YAxis FROM OrderDetails
                          JOIN Orders ON OrderDetails.orderID=Orders.id
                          GROUP BY Orders.memberID
                          ORDER BY SUM(OrderDetails.quantity) DESC";
            SqlCommand com = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                await using SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    (int, int) result = new();
                    result.Item1 = (int)reader["Xaxis"];
                    result.Item2 = (int)reader["YAxis"];

                    results.Add(result);
                }
                return results;
            }
            catch (Exception ex) { MessageBox.Show($"獲取會員銷售金額失敗\n{ex}"); return results; }
        }
    }
}
