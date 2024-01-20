using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Dati o valoare lui a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dati o valoare lui b:");
            b = Convert.ToInt32(Console.ReadLine());
            a = a * b;
            b = a / b;
            a = a / b;
            Console.Write("a="); Console.WriteLine(a);
            Console.Write("b="); Console.WriteLine(b);
            Console.ReadLine ();
        }
    }
}
