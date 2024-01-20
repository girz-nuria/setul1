using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y;
            Console.WriteLine("Dati un an:");
            y=Convert.ToInt32(Console.ReadLine());
            if (y % 4 == 0)
                Console.WriteLine("Anul "+y+" este bisect");
            else
                Console.WriteLine("Anul "+y+" nu este bisect");
            Console.ReadKey();
        }
    }
}
