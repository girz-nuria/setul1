using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine(" a= ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" b= ");
            b = Convert.ToInt32(Console.ReadLine());
            int rezultat = CalculGCD(a, b);

            Console.WriteLine($"Cel mai mare divizor comun al lui {a} si {b} este {rezultat}");
            Console.ReadKey();
        }

        static int CalculGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

    }
}
