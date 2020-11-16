using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CitiesByContinent
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> countries = new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split(' ').ToArray();
                var continent = arr[0];
                var country = arr[1];
                var city = arr[2];

                if (!countries.ContainsKey(continent))
                {
                    countries.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!countries[continent].ContainsKey(country))
                {
                    countries[continent].Add(country, new List<string>());
                }
                countries[continent][country].Add(city);
                
            }

            foreach (var item in countries)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var town in item.Value)
                {
                    
                    Console.WriteLine($"{town.Key} -> {String.Join(", ", town.Value)}");
                }
            }
        }
    }
}
