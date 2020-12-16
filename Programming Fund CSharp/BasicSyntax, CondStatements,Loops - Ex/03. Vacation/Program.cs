using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            decimal price = 0.0M;

            if (typeOfGroup == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 8.45M;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 9.80M;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 10.46M;
                }
            }
            else if (typeOfGroup == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 10.90M;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 15.60M;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 16.0M;
                }
            }
            else if (typeOfGroup == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 15.0M;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 20.0M;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 22.50M;
                }
            }

            decimal totalPrice = 0.0M;
            totalPrice = numOfPeople * price;
            if (typeOfGroup == "Students" && numOfPeople >= 30.0M)
            {
                totalPrice -= totalPrice * 0.15m;
            }
            else if (typeOfGroup == "Business" && numOfPeople >= 100.0M)
            {
                totalPrice -= price * 10.0m;
            }
            else if (typeOfGroup == "Regular" && numOfPeople >= 10.0M && numOfPeople <= 20.0M)
            {
                totalPrice -= totalPrice * 0.05m;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");

        }
    }
}
