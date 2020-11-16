using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {

                string[] arr = Console.ReadLine().Split(' ').ToArray();
                decimal result = decimal.Parse(arr[1]);

                if (!students.ContainsKey(arr[0]))
                {
                    students.Add(arr[0], new List<decimal>());
                }
                students[arr[0]].Add(result);

            }


            foreach (var item in students)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < item.Value.Count; i++)
                {
                    sb.Append($"{item.Value[i]:f2} ");
                }
                Console.WriteLine($"{item.Key} -> {sb.ToString()}(avg: {item.Value.Average():f2})");
            }
        }
    }
}
