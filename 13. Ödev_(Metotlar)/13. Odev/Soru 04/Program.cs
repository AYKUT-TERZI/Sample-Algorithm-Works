using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen a b c sayılarının toplam değerini giriniz.");
            int sum = int.Parse(Console.ReadLine());

            Console.WriteLine(FindPythagoreanTriplet(sum));

            Console.ReadKey();

        }

        private static int FindPythagoreanTriplet(int sum)
        {
            int product = 1;

            for (int a = 1; a < 1000/3; a++)
            {
                for (int b = 1; b < 1000/2; b++)
                {
                    for (int c = 1; c < 1000; c++)
                    {
                        if (a + b + c == 1000 && Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                        {
                            Console.WriteLine("a: " + a + " b: " + b + " c: " + c);
                            product = a * b * c;
                            break;
                        }
                    }
                }
            }

            return product;
        }
    }
}
