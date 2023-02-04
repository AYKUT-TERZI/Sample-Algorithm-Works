using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Soru: Faktöriyel işlemini Rekürsif metotlarla yapalım

            Console.WriteLine("Lütfen faktoriyelini almak istediğiniz sayıyı giriniz.");
            int sayi = int.Parse(Console.ReadLine());

            Console.WriteLine(Faktoriyel(sayi));


            Console.ReadKey();
         

        }

        private static int Faktoriyel(int sayi)
        {
            if (sayi == 0)
            {
                return 1;
            }
            return sayi * Faktoriyel(sayi - 1);
        }
    }
}
