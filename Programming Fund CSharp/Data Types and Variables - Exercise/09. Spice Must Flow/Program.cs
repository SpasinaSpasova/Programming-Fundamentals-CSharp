using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int leaving = 0;
            int days = 0;
            if (startingYield < 100)
            {
                Console.WriteLine(days);
                Console.WriteLine(leaving);
            }
            else
            {


                while (startingYield >= 100)
                {
                    leaving += startingYield - 26;

                    days++;
                    startingYield -= 10;
                }
                if (leaving > 26)
                {
                    Console.WriteLine(days);
                    Console.WriteLine(leaving - 26);

                }
            }
        }
    }
}

