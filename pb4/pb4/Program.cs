using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y;
            Console.WriteLine(" y=");
            y = Convert.ToInt32(Console.ReadLine());
            if (y % 4 == 0)
                Console.WriteLine(" anul este bisect ");
            else
                Console.WriteLine(" anul nu este bisect ");
            Console.ReadLine();
        }
    }
}
