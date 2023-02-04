using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiziTanımlaYazdir();


            Console.ReadKey();

        }

        private static void DiziTanımlaYazdir()
        {
            int[] sayilar = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Lütfen {i + 1}. sayıyı giriniz.");
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            DiziYazdir(sayilar);
        }

        private static void DiziYazdir(int[] sayilar)
        {
            foreach (int sayi in sayilar)
            {
                Console.Write(sayi + " ");
            }
        }
    }
}
