using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlcon = new SqlConnection();
            //  sqlcon.ConnectionString = "";

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DESKTOP-CU1M14V\\SQLKODLAB";
            builder.InitialCatalog = "SQLFULL";
            builder.UserID = "udemy1";
            builder.Password = "1";

            sqlcon.ConnectionString = builder.ConnectionString;
            sqlcon.Open();
            Console.WriteLine($"Bağlantı duurmu: {sqlcon.State}");
            sqlcon.Close();
            Console.WriteLine($"Bağlantı duurmu: {sqlcon.State}");
            Console.ReadLine();

        }
    }
}
