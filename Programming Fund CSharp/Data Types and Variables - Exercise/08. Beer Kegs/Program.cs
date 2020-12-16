using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfKegs = int.Parse(Console.ReadLine());
            double bigKegs = 0;
            string currentName = "";
            for (int i = 1; i <= numOfKegs; i++)
            {
                string name = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;

                if (volume >= bigKegs)
                {
                    bigKegs = volume;
                    currentName = name;

                }

            }
            Console.WriteLine($"{currentName}");
        }
    }
}
