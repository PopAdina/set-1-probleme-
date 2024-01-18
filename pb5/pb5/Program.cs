using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti un numar: ");
            string numar = Console.ReadLine();
            Console.WriteLine(" introduceti pozitia lui k:");
            int k = int.Parse(Console.ReadLine());  
            if (k >= 1 && k <= numar.Length)
            { char cifra = numar[numar.Length - k];
                Console.WriteLine($"cifra a {k} -a de la sfarsitul bumarului este: {cifra}"); }
            else { Console.WriteLine("pzitia cifrei (k) este incorecta. Numarul are doar " + numar.Length + " cifre de la dreapta la stanga. "); }
            Console.ReadLine();
        }
        
    }
}
