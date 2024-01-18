using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine(" n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" divizorii lui " + n + " sunt: ");

            for ( i = 1; i <= n; i++ )
            { if (n % i == 0)
                    Console.WriteLine( i + " " );
            }
           Console.ReadLine();
        }
    }
}
