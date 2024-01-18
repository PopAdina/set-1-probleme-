using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, x, delta;
            Console.WriteLine(" a= ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" b= ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" c= ");
            c = Convert.ToInt32(Console.ReadLine());
            delta = b * b - 4 * a * c; 
            if ( delta > 0 )
            { double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
              double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("ecuatia are solutii reale diferite");
                Console.WriteLine(" x1= " + x1);
                Console.WriteLine(" x2= " + x2);
            }
            else if (delta == 0)
            { x = -b / (2 * a);
                Console.WriteLine(" ecuatia are o solutie reala dubla x1=x2");
                Console.WriteLine(" x= " + x);
            }
            else { Console.WriteLine("ecuatia nu are solutii reale"); }
            Console.ReadLine();
        }
         
    }
}
