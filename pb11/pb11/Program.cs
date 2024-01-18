using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, c, inv = 0 ;
            Console.WriteLine(" n= ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                c = n % 10;
                inv = inv * 10 + c;
                n = n / 10;
            }
            Console.WriteLine("inversul numarului este: " + inv);
            Console.ReadLine();
        }
    }
}
