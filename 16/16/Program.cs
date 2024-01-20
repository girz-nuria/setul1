using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numere = new int[5];

            Console.WriteLine("Introduceti cele 5 numere:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Numarul {i + 1}: ");
                numere[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(numere);

            Console.WriteLine("Numerele în ordine crescatoare:");

            foreach (int numar in numere)
            {
                Console.WriteLine(numar);
            }
            Console.ReadKey();
        }
    }
}
