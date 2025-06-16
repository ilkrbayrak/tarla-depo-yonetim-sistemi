using MySql.Data.MySqlClient;

namespace TarlaDepoSistemi.Database
{
    public static class DbConnection
    {
        private static string connectionString = "Server=localhost;Database=veritabani;Uid=root;Pwd=15il36BAY;";
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
