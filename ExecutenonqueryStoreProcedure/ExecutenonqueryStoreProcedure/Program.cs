using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutenonqueryStoreProcedure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.MusteriID = 10;
            musteri.Isim = "Ali";
            musteri.Soyisim = "Veli";

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CU1M14V\\SQLKODLAB;Initial Catalog=SQLFULL;Integrated Security=True;Encrypt=False;User ID=udemy1;Password=1");
            SqlCommand cmd = new SqlCommand("sp_musteriKayit"); //sql de oluşturduğumuz procedure ismini yazıyoruz
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("@MusteriID",SqlDbType.Int).Value = musteri.MusteriID;
            cmd.Parameters.Add("@Isim", SqlDbType.NVarChar).Value = musteri.Isim;
            cmd.Parameters.Add("@Soyisim", SqlDbType.NVarChar).Value = musteri.Soyisim;

            con.Open();
            int deger = cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine($"etkilenen kayıt: {deger}");
            Console.ReadLine();

        }
    }
}
