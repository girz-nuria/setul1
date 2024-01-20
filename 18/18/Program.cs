using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, k=2, nr=0;
            Console.WriteLine("Dati o valoare lui n:");
            n=int.Parse(Console.ReadLine());    
            while(n!=1)
            {
                while(n%k==0)
                {
                    n = n / k;
                    nr++;
                }
                if(nr!=0)
                
                    Console.Write(k + "^" + nr+"*");
                    k++;
                    nr = 0;
                        
                        
                
            }

            Console.ReadKey();

        }
    }
}
