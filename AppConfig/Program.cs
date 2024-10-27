using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlcon = new SqlConnection();

            //2. adım 
            sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["SQLSQL"].ConnectionString;
            sqlcon.Open();
            Console.WriteLine($"bağlantı: {sqlcon.State}");
            sqlcon.Close();
            Console.WriteLine($"bağlantı: {sqlcon.State}");
            Console.ReadLine();
        }
    }
}
