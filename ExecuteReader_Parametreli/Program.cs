using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteReader_Parametreli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CU1M14V\\SQLKODLAB;Initial Catalog=SQLFULL;Integrated Security=True;Encrypt=False;User ID=udemy1;Password=1");
            SqlCommand cmd = new SqlCommand("select * from Musterim where MusteriID = @ID", con);

            cmd.Parameters.Add("@ID",SqlDbType.Int).Value = 1; //ıd si 1 olanı getir
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string isim = reader.GetString(1);
                string soyisim = reader.GetString(2);
                Console.WriteLine($"{id}{isim}{soyisim}");
            }
            reader.Close();
            con.Close();
            Console.ReadLine();
        }
    }
}
