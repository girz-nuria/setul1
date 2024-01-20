using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, c, inv, aux;
            inv = 0;
            Console.WriteLine("dati un numar:");
            n=Convert.ToInt32(Console.ReadLine());
            aux = n;
            while(n!=0) 
            { 
                c = n % 10;
                inv = inv * 10 + c;
                n = n / 10; 
            }
            Console.Write("inv="); Console.WriteLine(inv);
            if (aux == inv)
                Console.WriteLine("Numarul este palindrom");
            else
                Console.WriteLine("Numarul nu este palindrom");
            Console.ReadLine();

        }
    }
}
