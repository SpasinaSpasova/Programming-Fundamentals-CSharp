using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            decimal sum = 0m;

            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i];
               
                char letBefor = current[0];
                char letAfter = current[current.Length - 1];

               current= current.Remove(0, 1);
               current= current.Remove(current.Length-1, 1);
                decimal num = decimal.Parse(current.ToString());

                if (letBefor >= 65 && letBefor<=90)
                {
                    int position = letBefor - 64;
                    sum += num/ position;
                }
                else if (letBefor >= 97 && letBefor <= 122)
                {
                    int position = letBefor - 96;
                    sum += num * position;
                   
                }

                if (letAfter >= 65 && letAfter <= 90)
                {
                    int position = letAfter - 64;

                    sum -= position;
                }
                else if (letAfter >= 97 && letAfter <= 122)
                {
                    int position = letAfter - 96;
                    sum += position;

                }





            }
            Console.WriteLine($"{sum:f2}");

        }
    }
}
