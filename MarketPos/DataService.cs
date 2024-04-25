using Microsoft.SqlServer.Server;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
using System.Windows;

namespace MarketPos
{
    internal class DataService
    {
        private static string ConnString = "";
        private static async Task<bool> TryConnectionSql(SqlConnection conn)
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
        public static async Task<bool> ConnectionSql(string connString)
        {
            using SqlConnection conn = new(connString);
            ConnString = conn.ConnectionString;
            return await TryConnectionSql(conn);
        }
    }
}
