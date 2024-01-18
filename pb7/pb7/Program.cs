using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, aux;
            Console.WriteLine(" dati o valoare lui a ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" dati o valoare lui b ");
            b = Convert.ToInt32(Console.ReadLine());
            aux = 0;
            aux = a; 
            a = b;
            b = aux;
            Console.WriteLine(" a= " + a);
            Console.WriteLine(" b= " + b);
            Console.ReadLine();

        }
    }
}
