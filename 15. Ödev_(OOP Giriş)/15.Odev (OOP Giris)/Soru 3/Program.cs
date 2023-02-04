using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Topla(1,2,3,10));

            Console.ReadKey();
        }

        private static int Topla(params int[] sayilar)
        {
            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }

            return toplam;
        }
    }
}
