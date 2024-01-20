using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, c, i, k,p=1;
            Console.WriteLine("Dati un numar n:");
            n=int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());

            for (i=1;i<k;i++)
            {
               
                p = p * 10;
            }
            n = n / p;
            c = n % 10;
            Console.WriteLine("Cifra " + k + " este:");
            Console.WriteLine(c);
            Console.ReadKey();

           
            


        }
    }
}
