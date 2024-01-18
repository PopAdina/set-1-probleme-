using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, sf = 0;
            Console.WriteLine("dati un numar:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= n; i++)
                if (n % i == 0)
                    sf++;
            if (sf == 0) Console.WriteLine("numarul este prim");
            else Console.WriteLine(" numarul nu este prim ");
            Console.ReadKey();
        }
    }
}
