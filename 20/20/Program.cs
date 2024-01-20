using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numaratorul (m): ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numitorul (n): ");
            int n = int.Parse(Console.ReadLine());
            int cat = m / n;
            int rest = m % n;
            if (rest == 0)
            {
                Console.WriteLine($"Fractia {m}/{n} in format zecimal este: {cat}");
                Console.ReadLine();
                return;
            }
            List<int> zecimalaParte = new List<int>();
            List<int> periodicaParte = new List<int>();
            Dictionary<int, int> resturiVizitate = new Dictionary<int, int>();
            int pozitie = 0;
            while (rest != 0 && !resturiVizitate.ContainsKey(rest))
            {
                resturiVizitate.Add(rest, pozitie);
                rest *= 10;
                int catPartial = rest / n;
                int restPartial = rest % n;

                zecimalaParte.Add(catPartial);
                rest = restPartial;
                pozitie++;
            }
            if (rest == 0)
            {
                Console.WriteLine($"Fractia {m}/{n} in format zecimal este: {cat}.{string.Join("", zecimalaParte)}");
                Console.ReadLine();
            }
            else
            {
                int pozitieInceputPerioada = resturiVizitate[rest];
                periodicaParte.AddRange(zecimalaParte.GetRange(pozitieInceputPerioada, zecimalaParte.Count - pozitieInceputPerioada));
                zecimalaParte.RemoveRange(pozitieInceputPerioada, zecimalaParte.Count - pozitieInceputPerioada);

                Console.WriteLine($"Fractia {m}/{n} in format zecimal este: {cat}.{string.Join("", zecimalaParte)}({string.Join("", periodicaParte)})");
                Console.ReadLine();
            }
        }
    }
}
