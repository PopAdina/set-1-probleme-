using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti 5 numere:");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
   
            Sorteaza(ref a, ref b);
            Sorteaza(ref a, ref c);
            Sorteaza(ref a, ref d);
            Sorteaza(ref a, ref e);
            Sorteaza(ref b, ref c);
            Sorteaza(ref b, ref d);
            Sorteaza(ref b, ref e);
            Sorteaza(ref c, ref d);
            Sorteaza(ref c, ref e);
            Sorteaza(ref d, ref e);
            Console.WriteLine("Numerele in ordine crescatoare sunt: ");
            Console.WriteLine($"{a}, {b}, {c}, {d}, {e}");
            Console.ReadKey();
        }
        static void Sorteaza(ref int a, ref int b)
        {
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
        }
    }
}
