using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlCommandKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CU1M14V\\SQLKODLAB;Initial Catalog=SQLFULL;Integrated Security=True;Encrypt=False;User ID=udemy1;Password=1");
            SqlCommand cmd = new SqlCommand("insert into Musterim values (1,'emek','manduz')",con);
            con.Open();
            int kacKayitVar = cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine(kacKayitVar);
            Console.ReadLine();

        }
    }
}
