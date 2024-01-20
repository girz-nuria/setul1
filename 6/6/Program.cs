using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.Write("Dati o valoare laturii a:");
            a = float.Parse(Console.ReadLine());
            Console.Write("Dati o valoare laturii b:");
            b = float.Parse(Console.ReadLine());
            Console.Write("Dati o valoare laturii c:");
            c = float.Parse(Console.ReadLine());
            if (a + b > c && b + c > a && a + c > b)
                Console.WriteLine("da");
            else
                Console.WriteLine("nu");
            Console.ReadKey();
        }
    }
}
