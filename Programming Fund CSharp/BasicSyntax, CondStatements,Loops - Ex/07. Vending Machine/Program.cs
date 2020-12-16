using System;
using System.Data.SqlTypes;
using System.Threading;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string coins = Console.ReadLine();
            decimal sum = 0.0M;

            while (coins != "Start")
            {
                if (coins == "0.1" || coins == "0.2" || coins == "0.5" || coins == "1" || coins == "2")
                {
                    sum += decimal.Parse(coins);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                coins = Console.ReadLine();
            }
            string product = Console.ReadLine();
            while (product != "End")
            {

                decimal price = 0.0M;

                if (product == "Nuts")
                {
                    price = 2.0M;
                }
                else if (product == "Water")
                {
                    price = 0.7M;
                }
                else if (product == "Crisps")
                {
                    price = 1.5M;
                }
                else if (product == "Soda")
                {
                    price = 0.8M;
                }
                else if (product == "Coke")
                {
                    price = 1.0M;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    product = Console.ReadLine();
                    continue;
                }

                if (price > sum)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else 
                {
                    
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        sum = sum - price;
                    
                }

                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
