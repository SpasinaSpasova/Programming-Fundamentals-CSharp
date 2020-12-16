using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            string games = Console.ReadLine();

            double priceOfGame = 0;

            double spentOfGames = 0;

            while (games != "Game Time")
            {
                switch (games)
                {
                    case "OutFall 4":
                        priceOfGame = 39.99;
                        break;
                    case "CS: OG":
                        priceOfGame = 15.99;
                        break;
                    case "Zplinter Zell":
                        priceOfGame = 19.99;
                        break;
                    case "Honored 2":
                        priceOfGame = 59.99;
                        break;
                    case "RoverWatch":
                        priceOfGame = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        priceOfGame = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                if (priceOfGame > currentBalance)
                {
                    Console.WriteLine("Too Expensive");


                }
                else
                {
                    spentOfGames += priceOfGame;

                }
                if ((games == "OutFall 4" || games == "CS: OG" || games == "Zplinter Zell" ||
                   games == "Honored 2" || games == "RoverWatch" || games == "RoverWatch Origins Edition") && (currentBalance >= priceOfGame))
                {

                    Console.WriteLine($"Bought {games}");
                    currentBalance -= priceOfGame;
                }
                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }



                games = Console.ReadLine();
            }
            Console.Write($"Total spent: ${spentOfGames:f2}. ");
            Console.Write($"Remaining: ${currentBalance:f2}");

        }
    }
}
