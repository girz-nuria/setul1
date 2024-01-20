using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, n, i, sf=0;
            Console.Write("Dati o valoare lui a:");
            a=int.Parse(Console.ReadLine());
            Console.Write("Dati o valoare lui b:");
            b =int.Parse(Console.ReadLine());
            Console.Write("Dati o valoare lui n:");
            n = int.Parse(Console.ReadLine());
            for (i = a; i <= b; i++)
                if (i % n == 0)
                    sf++;
            Console.Write("Numarul numerelor intregi divizibile cu " + n + " din intervalul [" + a + "," + b + "] este :");
            Console.WriteLine(sf);
            Console.ReadKey();



        }
    }
}
