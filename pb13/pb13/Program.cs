using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y1, y2, i, sf=0;
            Console.WriteLine(" y1= ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" y2= ");
            y2 = Convert.ToInt32(Console.ReadLine());  
            for ( i = y1 + 1; i < y2; i++)
                if (i%4 == 0)
                    sf++;
            Console.WriteLine(" numarul anilor bisecti: ");
            Console.WriteLine(sf);
            Console.ReadKey();


        }
    }
}
