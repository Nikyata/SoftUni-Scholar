using System.Collections.Generic;

namespace _05.CitiesbyContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> kvp = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (kvp.ContainsKey(continent))
                {
                    if (!kvp[continent].ContainsKey(country))
                    {
                        kvp[continent].Add(country, new List<string>());
                        kvp[continent][country].Add(city);
                    }
                    else
                    {
                        kvp[continent][country].Add(city);
                    }
                   
                }
                else
                {
                    kvp.Add(continent, new Dictionary<string, List<string>>());
                    kvp[continent].Add(country, new List<string>());
                    kvp[continent][country].Add(city);
                }
            }

            foreach (var continent in kvp)
            {
                Console.WriteLine(continent.Key +":");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
