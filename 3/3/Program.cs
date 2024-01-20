using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            Console.Write("Dati o valoare lui n=");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dati o valoare lui k=");
            k = Convert.ToInt32(Console.ReadLine());
            if (n % k == 0)
                Console.WriteLine("Numarul se divide ");
            else
                Console.WriteLine("Numarul nu se divide");
            Console.ReadKey();
        }
    }
}
