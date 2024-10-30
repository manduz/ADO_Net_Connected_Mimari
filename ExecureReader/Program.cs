using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecureReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CU1M14V\\SQLKODLAB;Initial Catalog=SQLFULL;Integrated Security=True;Encrypt=False;User ID=udemy1;Password=1");
            SqlCommand cmd = new SqlCommand("select * from Musterim", con);

            con.Open();
            SqlDataReader sqlReader = cmd.ExecuteReader();

            while (sqlReader.Read())
            {
                
                int id = (int)sqlReader[0];//1.yöntem veri alma kodu
                string isim = sqlReader["Isim"].ToString();//2. yöntem veriyi alabilmek için
                string Soyisim = sqlReader.GetString(2);//2 numara kolon numarasıdır 3. yöntem veri almak için
                Console.WriteLine($"{id} {isim} {Soyisim}");
            }
            sqlReader.Close();
            con.Close();
            Console.ReadLine();
            


        }
    }
}
