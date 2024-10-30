using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ExecureReader_Store_Procedure
{
    internal class Musteri
    {
        public int MuteriID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
    }
    internal class Program
    {
       
        static void Main(string[] args)
        {

            List<Musteri> list = new List<Musteri>();

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CU1M14V\\SQLKODLAB;Initial Catalog=SQLFULL;Integrated Security=True;Encrypt=False;User ID=udemy1;Password=1");
            SqlCommand cmd = new SqlCommand("sp_musterilerim", con);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;//sp_musterilerim procedure olduğunu belirtmek için bu satırı yazıyoruz
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Musteri()
                {
                    MuteriID = reader.IsDBNull(0) ? 0:reader.GetInt32(0),
                    Isim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    Soyisim = reader.IsDBNull(2) ? string.Empty : reader.GetString(2)
                });
               
            }
            reader.Close();
            con.Close();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{list[i].MuteriID} {list[i].Isim} {list[i].Soyisim}");
            }
            Console.ReadLine();


        }
    }
}
