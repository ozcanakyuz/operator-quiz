using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 5;
            int z = 10;

            Console.WriteLine("1.Sayı: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2.Sayi ");
            int sayi2 = int.Parse(Console.ReadLine());

            double sonuc = Math.Pow(y, x);
            Console.WriteLine(sonuc);

            //val = (y * z) - (x + y + z);
            //if (x % 2 == 0)
            //{
            //    Console.WriteLine("Çift");
            //} else
            //{
            //    Console.WriteLine("Tek");
            //}

            //val = (x + y + z) % 3;
            //Console.WriteLine(val);

            
        }
    }
}
