﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, x;
            Console.Write("Introduceti a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Introduceti b = ");
            b = float.Parse(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                    Console.WriteLine("Ecuatie nedet. ");
                else
                    Console.WriteLine("Ecuatie imposibila");
            else
            {
                x = -b / a;
                Console.WriteLine("Solutia este x = {0}", x);
            }
            Console.ReadKey();

        }
    }
}
