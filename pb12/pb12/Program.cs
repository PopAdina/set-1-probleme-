using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti primul capat al intervalului:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti al doilea capat al intervalului:");
            int b = int.Parse(Console.ReadLine());  
            Console.WriteLine("introduceti numarul cu care sa fie divizibil numerele (n): ");
            int n = int.Parse(Console.ReadLine());
            int rezultat = (b / n) - ((a - n) / n);
            Console.WriteLine($"Numarul de numere divizibile cu {n} in intervalul [{a}, {b}] este: {rezultat}");
            Console.ReadLine();
        }
    }
}
