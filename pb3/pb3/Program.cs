using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            Console.WriteLine(" n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" k = ");
            k = Convert.ToInt32(Console.ReadLine());
            if (n % k == 0)
                Console.WriteLine(" n se divide cu k ");
            else
                Console.WriteLine(" n nu se divide cu k ");
            Console.ReadLine();
        }
    }
}
