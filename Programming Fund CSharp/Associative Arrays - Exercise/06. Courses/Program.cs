using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while (input != "end")
            {
                string[] cmdArg = input.Split(":",StringSplitOptions.RemoveEmptyEntries).ToArray();
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
        }
    }
}
