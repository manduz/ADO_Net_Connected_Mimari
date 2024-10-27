using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baglanti_Kontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            dataAccessLayer.TestBaglanti();
            Console.ReadLine();
        }
    }
}
