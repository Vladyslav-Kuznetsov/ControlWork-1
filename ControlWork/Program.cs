using System;

namespace ControlWork
{
    struct City
    {
        public int Populated;
        public string Name;
        public int Area;
        public double Density;
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] result = Console.ReadLine().Split(';');
            City[] cities = new City[result.Length];

            for (int i = 0; i < cities.Length; i++)
            {
                City newCity = new City();
                string[] nameSplit = result[i].Split('=');
                string[] values = nameSplit[1].Split(',');
                newCity.Name = nameSplit[0];
                newCity.Populated = int.Parse(values[0]);
                newCity.Area = int.Parse(values[1]);
                
                newCity.Density = Convert.ToDouble(newCity.Populated) / Convert.ToDouble(newCity.Area);
                cities[i] = newCity;
            }

            string longestName = string.Empty;
            string mostPopulated = string.Empty;
            int maxpeopple = 0;

            for (int i = 0; i < cities.Length; i++)
            {
                if (longestName.Length < cities[i].Name.Length)
                {
                    
                    longestName = cities[i].Name;
                }
                if (maxpeopple < cities[i].Populated)
                {
                    maxpeopple = cities[i].Populated;
                    mostPopulated = $"{cities[i].Name} ({maxpeopple} peopple)";
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