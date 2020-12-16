using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int tankCapacity = 255;
            int count = int.Parse(Console.ReadLine());
            int capasity = 0;
            for (int i = 1; i <= count; i++)
            {
                int litters = int.Parse(Console.ReadLine());
                
                if (capasity + litters > tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                   
                }
                else
                {
                    capasity +=litters;
                }
            }
            Console.WriteLine(capasity);
        }
    }
}
