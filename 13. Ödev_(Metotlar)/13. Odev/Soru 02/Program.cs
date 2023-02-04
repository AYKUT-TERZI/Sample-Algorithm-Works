using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_02
{
    internal class Program
    {
        // Answer: 25.164.150

        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz.");
            int sayi = int.Parse(Console.ReadLine());

            Console.WriteLine(DifferenceOfSquares(sayi));

            Console.ReadKey();
        }

        private static double DifferenceOfSquares(int sayi)
        {
            double sumOfSquares = 0;
            int sum = 0;

            for(int i=1; i<=sayi; i++)
            {
                sumOfSquares += Math.Pow(i, 2);
                sum += i;
            }

            double squareOfSum = Math.Pow(sum, 2);

            return squareOfSum-sumOfSquares;
        }
    }
}
