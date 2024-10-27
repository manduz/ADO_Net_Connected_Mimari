using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baglanti_Kontrol
{
    internal class DataAccessLayer
    {
        SqlConnection connect;
        public DataAccessLayer() //constructer
        {
            connect = new SqlConnection();
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["emek"].ConnectionString;

        }
        void BaglantiYonetim()
        {
            if (connect.State == System.Data.ConnectionState.Open)
            {
                connect.Close();
            }
            else
                connect.Open();
        }
        public void TestBaglanti()
        {
            BaglantiYonetim();
            Console.WriteLine($"Bağlantı duurmu: {connect.State}");
            BaglantiYonetim();
            Console.WriteLine($"Bağlantı duurmu: {connect.State}");
        }
    }
}
