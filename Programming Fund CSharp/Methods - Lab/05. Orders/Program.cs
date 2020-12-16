using System;
using System.Net.Http.Headers;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();

            double quantity = double.Parse(Console.ReadLine());

            Total(product,quantity);

        }

        static void Total(string product, double quantity)
        {
            double price = 0;

            if (product == "coke")
            {
                price = quantity * 1.40;
            }
            else if (product == "coffee")
            {
                price = quantity * 1.50;
            }
            else if (product == "water")
            {
                price = quantity * 1;
            }
            else if (product=="snacks")
            {
                price = quantity * 2;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
