using System;

namespace _07._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfTheDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            double price = 0;
            if (typeOfTheDay == "Weekday")
            {
                if (0 <= age && age <= 18)
                {
                    price = 12;
                }
                else if (18 < age && age <= 64)
                {
                    price = 18;
                }
                else if (64 < age && age <= 122)
                {
                    price = 12;
                }
                
                
            }
            else if (typeOfTheDay == "Weekend")
            {
                if (0 <= age && age <= 18)
                {
                    price = 15;
                }
                else if (18 < age && age <= 64)
                {
                    price = 20;
                }
                else if (64 < age && age <= 122)
                {
                    price = 15;
                }
                
            }
            else if (typeOfTheDay == "Holiday")
            {
                if (0 <= age && age <= 18)
                {
                    price = 5;
                }
                else if (18 < age && age <= 64)
                {
                    price = 12;
                }
                else if (64 < age && age <= 122)
                {
                    price = 10;
                }
                
            }
            if (price>=5&&price<=20)
            {
                Console.WriteLine($"{price}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }

        }
    }
}
