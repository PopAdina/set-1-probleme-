using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("primul numar: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine(" al doilea numar: ");
            y = int.Parse(Console.ReadLine());    
            Console.WriteLine(" al treilea numar:");
            z = int.Parse(Console.ReadLine());
            if ( x<= y )
           
                if( y <= z ) { Console.WriteLine(x); Console.WriteLine(y); Console.WriteLine(z); }
            else 
                if (x<=z ) { Console.WriteLine(x); Console.WriteLine(z); Console.WriteLine(y);}
           else {  Console.WriteLine(z); Console.WriteLine(x); Console.WriteLine(y);}
            else 
                if(z<=y) { Console.WriteLine(z); Console.WriteLine(y); Console.WriteLine(x); }
            else 
                if(z<=x) { Console.WriteLine(y); Console.WriteLine(z); Console.WriteLine(x); }
            else { Console.WriteLine(y); Console.WriteLine(x); Console.WriteLine(z); }
            Console.ReadLine();
                

        }
    }
}
