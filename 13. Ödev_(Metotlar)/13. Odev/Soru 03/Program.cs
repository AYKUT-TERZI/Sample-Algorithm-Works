using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_03
{
    internal class Program
    {
        // Answer: 104743
        
        static void Main(string[] args)
        {
            // By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13. What is the 10 001st prime number ? => 104743

            Console.WriteLine("Lütfen kaçıncı sıradaki asal sayıyı görmek istiyorsanız onun sıra numarasını giriniz.");
            int sira = int.Parse(Console.ReadLine());

            Console.WriteLine(FindPrimeNumber(sira));

            Console.ReadKey();
        }

        private static int FindPrimeNumber(int sira)
        {
            int sayi = 2;
            int sayac = 0;
           
            while(true)
            {
                int sayac2 = 0;

                for (int i=2; i<=sayi; i++)
                {
                    if(sayi%i==0)
                    {
                        sayac2++;
                    }
                }

                if (sayac2 == 1)
                {
                    sayac++;
                }

                if (sayac == sira)
                {
                    return sayi;
                }
                
                sayi++;
            }
        }
    }
}
