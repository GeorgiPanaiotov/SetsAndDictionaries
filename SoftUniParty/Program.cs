using System;
using System.Collections.Generic;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            HashSet<string> guests = new HashSet<string>();
            while (input != "END")
            {
                if ((!guests.Contains(input)) && input.Length == 8)
                {
                    guests.Add(input);
                }
                else
                {
                    guests.Remove(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(guests.Count);
            foreach (var item in guests)
            {
                Console.WriteLine(item);
            }
        }
    }
}
