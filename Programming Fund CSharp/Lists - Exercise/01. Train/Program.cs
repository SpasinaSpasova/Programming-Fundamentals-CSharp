using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string[] commnad = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (commnad[0]!="end")
            {

                if (commnad[0]=="Add")
                {
                    train.Add(int.Parse(commnad[1]));
                }
                else
                {
                    int passenger = int.Parse(commnad[0]);
                    for (int i = 0; i < train.Count; i++)
                    {
                        if (passenger + train[i]<=maxCapacity)
                        {
                            train[i] += passenger;
                            break;
                        }
                    }
                   
                }
                commnad = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(string.Join(" ",train));
        }
    }
}
