using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, double> namesAndPoints = new Dictionary<string, double>();

            Dictionary<string, int> languageAndSubmissions = new Dictionary<string, int>();
           
            while (input != "exam finished")
            {
                string[] command = input.Split("-");

                string username = command[0];
                if (command.Length > 2)
                {
                    double points = double.Parse(command[2]);
                    string language = command[1];
                    if (namesAndPoints.ContainsKey(username))
                    {
                        if (namesAndPoints[username] < points)
                        {
                            namesAndPoints[username] = points;
                        }
                    }
                    else
                    {
                        namesAndPoints.Add(username, points);
                    }

                    if (languageAndSubmissions.ContainsKey(language))
                    {
                        languageAndSubmissions[language]++;
                    }
                    else
                    {
                        languageAndSubmissions.Add(language, 1);
                    }
                }
                else
                {
                    if (namesAndPoints.ContainsKey(username))
                    {
                        namesAndPoints.Remove(username);
                    }
                }


                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");
            foreach (var item in namesAndPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in languageAndSubmissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
