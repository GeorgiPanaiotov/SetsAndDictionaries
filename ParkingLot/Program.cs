using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(", ").ToArray();

            HashSet<string> cars = new HashSet<string>();

            while(arr[0] != "END")
            {
                if(arr[0] == "IN")
                {
                    cars.Add(arr[1]);
                }
                else if(arr[0] == "OUT")
                {
                    cars.Remove(arr[1]);
                }
                arr = Console.ReadLine().Split(", ").ToArray();
            }
            if(cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
                Environment.Exit(0);
            }
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
        }
    }
}
