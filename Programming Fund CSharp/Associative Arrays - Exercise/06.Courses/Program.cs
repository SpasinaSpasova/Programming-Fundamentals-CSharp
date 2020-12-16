using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while (input != "end")
            {
                string[] cmdArg = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string nameCourse = cmdArg[0];
                string nameStudent = cmdArg[1];

                if (courses.ContainsKey(nameCourse))
                {
                    courses[nameCourse].Add(nameStudent);
                }
                else
                {
                    courses.Add(nameCourse, new List<string>() { nameStudent });
                }

                input = Console.ReadLine();
            }
            foreach (var item in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var kvp in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {kvp}");
                }
            }
        }
    }
}
