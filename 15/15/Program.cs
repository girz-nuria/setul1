using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Introduceti primul numar:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti al treilea numar:");
            z = Convert.ToInt32(Console.ReadLine());
            if (x <= y)
                if (y <= z)
                    Console.WriteLine(x + " " + y + " " + z);
                else

                    if (x <= z)
                    Console.WriteLine(x + " " + z + " " + y);
                else
                    Console.WriteLine(z + " " + x + " " + y);
            else
                if (z <= y)
                Console.WriteLine(z + " " + y + " " + x);
            else
                if (z <= x)
                Console.WriteLine(y + " " + z + " " + x);
            else
                Console.WriteLine(y + " " + x + " " + z);
            Console.ReadLine();
        }
    }
}
