using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, aux=0;
            Console.Write("Dati o valoare lui a:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Dati o valoare lui b:");
            b=Convert.ToInt32(Console.ReadLine());
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.ReadKey();
        }
    }
}
