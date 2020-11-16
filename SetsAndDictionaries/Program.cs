using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            Dictionary<double, int> pairs = new Dictionary<double, int>();

            for (int i = 0; i < list.Count; i++)
            {
                int count = 1;
                for (int j = i+1; j < list.Count; j++)
                {
                    if(list[i] == list[j])
                    {
                        count++;
                        list.RemoveAt(j);
                        j--;
                    }
                }
                pairs.Add(list[i], count);
            }

            foreach (var item in pairs)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
