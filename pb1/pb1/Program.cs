using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float  a, b, x;
            Console.WriteLine("a=");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            b = float.Parse(Console.ReadLine());
            if (a != 0)
            {
                x = -b / a;
                Console.WriteLine(" x= " + x);
            }
            else { if ( b == 0)
                { Console.WriteLine(" ecuatia are o infinitate de solutii");}
                   else { Console.WriteLine(" ecuatia nu are solutii reale"); }
            }
             Console.ReadLine();
        }
    }
}
