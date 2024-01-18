using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine(" a = ");
            a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" b = ");
            b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" c= ");
            c= Convert.ToInt32(Console.ReadLine());
            if (a < b + c && b < c + a && c < a + b)
            { Console.WriteLine(" numerele pot fi laturile unui triunghi "); }
            else
            {
                Console.WriteLine(" numerele nu pot fi laturile unui triunghi ");
            }
            Console.ReadLine ();
        }
    }
}
