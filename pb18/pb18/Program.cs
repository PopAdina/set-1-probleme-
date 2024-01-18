using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti un număr: ");
            int n = int.Parse(Console.ReadLine());
            int factor = 2;
            Console.Write($"Descompunerea în factori primi ai lui {n} este: ");
            while (n > 1)
            {
                if (n % factor == 0)
                {
                    int count = 0;
                    while (n % factor == 0)
                    {
                        n /= factor;
                        count++;
                    }
                    Console.Write($"{factor}^{count}");
                    if (n > 1)
                    {
                        Console.Write(" x ");
                    }
                }
                factor++;
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
