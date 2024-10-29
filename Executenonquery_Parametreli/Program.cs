using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Executenonquery_Parametreli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.MusteriID = 5;
            musteri.Isim = "Emek";
            musteri.Soyisim = "Manduz";

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CU1M14V\\SQLKODLAB;Initial Catalog=SQLFULL;Integrated Security=True;Encrypt=False;User ID=udemy1;Password=1");
            SqlCommand cmd = new SqlCommand("insert into Musterim values(@ID,@Isim,@Soyisim)",con);
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = musteri.MusteriID;
            cmd.Parameters.Add("@Isim", SqlDbType.NVarChar).Value = musteri.Isim;
            cmd.Parameters.Add("@Soyisim", SqlDbType.NVarChar).Value = musteri.Soyisim;

            con.Open();
            int deger = cmd.ExecuteNonQuery();

            con.Close();

            Console.WriteLine($"etkilenen kayıt sayısı {deger}");
            Console.ReadLine();
        }
    }
}
