using System;

namespace ControlWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] result = Console.ReadLine().Split(';');
            string longestName = string.Empty;
            string mostPopulated = string.Empty;
            int maxPeopple = 0;
            City[] cities = new City[result.Length];

            for (int i = 0; i < cities.Length; i++)
            {
                cities[i] = new City(result[i]);
                if (longestName.Length < cities[i].Name.Length)
                {
                    longestName = cities[i].Name;
                }
                if (maxPeopple < cities[i].Populated)
                {
                    maxPeopple = cities[i].Populated;
                    mostPopulated = $"{cities[i].Name} ({maxPeopple} peopple)";
                }
            }

            Console.WriteLine($"Most populated : {mostPopulated}");
            Console.WriteLine($"Longest name: {longestName} ({longestName.Length} letter)");
            Console.WriteLine("Dencity:");
            foreach (City c in cities)
            {
                Console.WriteLine($"\t{c.Name} - {Math.Round(c.Density,2)}");
            }

            Console.ReadLine();
        }

    }
}