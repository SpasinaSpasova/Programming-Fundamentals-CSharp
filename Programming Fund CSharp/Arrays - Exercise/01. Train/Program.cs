using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfWagons = int.Parse(Console.ReadLine());
            int[] wagons = new int[numOfWagons];
            int sum = 0;
            for (int i = 0; i < numOfWagons; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                sum += wagons[i];
            }
            Console.WriteLine(string.Join(" ",wagons));
            Console.WriteLine(sum);
        }
    }
}
