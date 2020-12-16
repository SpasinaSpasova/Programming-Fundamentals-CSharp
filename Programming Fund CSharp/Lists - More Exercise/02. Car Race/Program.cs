using System;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstCar = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int[] secondCar = firstCar.Reverse().ToArray();
            int middle = firstCar.Length / 2;

            double sumFirts = 0;
            double sumSecond = 0;
            for (int first = 0; first < middle; first++)
            {
                sumFirts += firstCar[first];
                if (firstCar[first] ==0)
                {
                    sumFirts *= 0.8;
                }
            }
            for (int second = 0; second < middle; second++)
            {
                sumSecond += secondCar[second];
                if (secondCar[second] == 0)
                {
                    sumSecond *= 0.8;
                }
            }

            if (sumFirts<sumSecond)
            {
                Console.WriteLine($"The winner is left with total time: {sumFirts}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {sumSecond}");
            }

        }
    }
}
