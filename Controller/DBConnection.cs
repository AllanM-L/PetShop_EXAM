namespace PetShop.Controller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.SqlClient;
    public class DBConnection
    {
        private static readonly string connectionString = "Server=DESKTOP-6IIB0IE\\SQLEXPRESS;Database=PetShopDB;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}

