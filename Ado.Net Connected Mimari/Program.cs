using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Net_Connected_Mimari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = "Data Source=DESKTOP-CU1M14V\\SQLKODLAB;Initial Catalog=SQLFULL;User ID=udemy1;Encrypt=False;Password=1";
            sqlcon.Open();//C# ile sql server bağlantısını açar
            Console.WriteLine($"Bağlantı Durumu: {sqlcon.State}");
            sqlcon.Close();
            Console.WriteLine($"Bağlantı Durumu: {sqlcon.State}");
            Console.ReadLine();


        }
    }
}
