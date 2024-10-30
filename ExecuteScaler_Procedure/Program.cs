using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteScaler_Procedure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CU1M14V\\SQLKODLAB;Initial Catalog=SQLFULL;Integrated Security=True;Encrypt=False;User ID=udemy1;Password=1");
            SqlCommand cmd = new SqlCommand("sp_musteriisim", con);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@MusteriID",SqlDbType.Int).Value = 5;

            con.Open();
            string isim = cmd.ExecuteScalar().ToString();
            con.Close();

            Console.WriteLine($"{isim}");
            Console.ReadLine();

        }
    }
}
