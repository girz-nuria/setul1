using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, c1, c2, sf , aux;
            Console.WriteLine("Dati un numar n:");
            n=int.Parse(Console.ReadLine());
            aux = n;
            c1 = n % 10;
            while (n % 10 == c1)
                n = n / 10;
            c2 = n % 10;
            n = aux;
            sf = 0;
            while (n != 0)
            {
                if (n % 10 != c1 && n % 10 != c2)

                    sf = 1;
                n = n / 10;
            }
            
            if (sf == 0)
                Console.WriteLine("Numarul este format din cifre care se pot repeta");
            else
                Console.WriteLine("numarul nu");
            Console.ReadKey();



        }
    }
}
