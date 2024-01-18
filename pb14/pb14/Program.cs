using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar: ");
            int numar = Convert.ToInt32(Console.ReadLine());
            if (EstePalindrom(numar))
            {
                Console.WriteLine($"{numar} este palindrom.");
            }
            else
            {
                Console.WriteLine($"{numar} nu este palindrom.");
            }
            Console.ReadKey();
        }

        static bool EstePalindrom(int numar)
        {
            int original = numar;
            int invers = 0;

            while (numar > 0)
            {
                int cifra = numar % 10;
                invers = invers * 10 + cifra;
                numar = numar / 10;
            }

            return original == invers;
            
        }
    }
}
