using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteScalerParametreli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CU1M14V\\SQLKODLAB;Initial Catalog=SQLFULL;Integrated Security=True;Encrypt=False;User ID=udemy1;Password=1");
            SqlCommand cmd = new SqlCommand("select Isim from Musterim where MusteriID = @ID",con);
            cmd.Parameters.Add("@ID",SqlDbType.Int).Value = 5; //class oluştuurpdaha sonra bu sayfada newleyip atama yapılabilirdi

            con.Open();
            string isim =  cmd.ExecuteScalar().ToString();
            con.Close();
            Console.WriteLine($"{isim}");
            Console.ReadLine();

        }
    }
}
