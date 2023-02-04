using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder. What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20 ? => 232.792.560

            Console.WriteLine("Lütfen kaça kadar sayılara bölünebilen en küçük sayıyı öğrenmek istediğiniz sınır değerini giriniz.");

            int sinir = int.Parse(Console.ReadLine());

            Console.WriteLine(EnKucukBolunebilen(sinir));

            Console.ReadKey();
        }

        private static int EnKucukBolunebilen(int sinir)
        {
            int i = 1;
            while(true)
            {
                int sayac = 0;
                for(int j=1; j <= sinir; j++)
                {
                    if (i % j != 0)
                    {
                        break;
                    }
                    else
                    {
                        sayac++;
                    }
                }

                if (sayac == sinir)
                {
                    return i;
                }
                i++;
            }
        }
    }
}
