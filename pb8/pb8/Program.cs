using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine(" a= ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" b= ");
            b = Convert.ToInt32(Console.ReadLine());
            (a, b) = (b, a);
            Console.WriteLine("a= " +a);
            Console.WriteLine(" b= " +b);
            Console.ReadLine(); 
        }
    }
}
