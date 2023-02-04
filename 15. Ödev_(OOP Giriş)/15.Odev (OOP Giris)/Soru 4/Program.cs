using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carpim();

            Console.ReadKey();
        }

        private static void Carpim()
        {
            Console.WriteLine("Hoşgeldiniz. Bu program gireceğiniz iki sayının çarpımını ekrana yazdırır.");

            Console.WriteLine("Lütfen 1. sayıyı giriniz.");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2. sayıyı giriniz.");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Girdiğiniz iki sayının çarpımı: " + sayi1 * sayi2);

            Console.WriteLine("Programı kullandığınız için teşekkür ederiz. Görüşmek üzere.");
        }
    }
}
