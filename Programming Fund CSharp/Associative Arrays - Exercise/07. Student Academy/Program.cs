using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> student = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (student.ContainsKey(name))
                {
                    student[name].Add(grade);
                }
                else
                {
                    student.Add(name, new List<double>());
                    student[name].Add(grade);
                }

            }
            foreach (var item in student.Where(x=>x.Value.Average()>=4.50).OrderByDescending(x => x.Value.Average()))
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
            }
        }
    }
}
