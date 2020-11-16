using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            string[] input = Console.ReadLine().Split(", ").ToArray();


            while(input[0] != "Revision")
            {
                var shop = input[0];
                var product = input[1];
                var price = double.Parse(input[2]);
                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }
                if (!shops[shop].ContainsKey(product))
                {
                    shops[shop].Add(product, price);
                }
                else
                {
                    shops[shop].Add(product, price);
                }
                input = Console.ReadLine().Split(", ").ToArray();
            }

            foreach (var item in shops)
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var dict in shops[item.Key])
                {
                    Console.WriteLine($"Product: {dict.Key}, Price: {dict.Value}");
                }
            }
        }
    }
}
