using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y = 0;
            Console.WriteLine("Dati un numar:");
            x = Convert.ToInt32(Console.ReadLine());
            while (x != 0)
            {
                y = y * 10 + x % 10;
                x = x / 10;
            }
            Console.Write("Inversul numarului este:"); Console.WriteLine(y);
            Console.ReadLine();

        }
    }
}
