using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, sf = 0;
            Console.WriteLine("Dati un numar:");
            n=Convert.ToInt32(Console.ReadLine());
            for(i=2; i<n; i++) 
                if(n%i==0)
                    sf++;
            if (sf == 0) Console.WriteLine("Numarul este prim");
            else Console.WriteLine("Numarul nu este prim");
            Console.ReadKey();


        }
    }
}
