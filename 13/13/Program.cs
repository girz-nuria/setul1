using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        { int y1, y2 ,i,sf=0;
            Console.Write("y1=");
            y1=int.Parse(Console.ReadLine());
            Console.Write("y2=");
            y2 =int.Parse(Console.ReadLine());
            for (i = y1+1; i < y2; i++)

                if (i % 4 == 0)
                    sf++;
                
            Console.Write("Numarul anilor bisecti intre "+y1+" si "+y2+" este:");
            Console.WriteLine(sf);
            Console.ReadKey();
                   

        }
    }
}
