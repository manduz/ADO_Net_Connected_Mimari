using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteScaler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CU1M14V\\SQLKODLAB;Initial Catalog=SQLFULL;Integrated Security=True;Encrypt=False;User ID=udemy1;Password=1");
            SqlCommand cmd = new SqlCommand("select Isim from Musterim where MusteriID = 5",con);

            con.Open();
            //ExecuteScalar, SQL sorgusunun sonucundan yalnızca tek bir değer döndürmek için kullanılan bir komuttur.
            string isim = cmd.ExecuteScalar().ToString();
            con.Close();
            Console.WriteLine($"{isim}");
            Console.ReadLine();
        }
    }
}
