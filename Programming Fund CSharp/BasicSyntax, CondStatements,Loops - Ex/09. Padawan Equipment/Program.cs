using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int numOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());
           
            double total = 0;
            double freeBelt = numOfStudents/6;//!!!!!
           

            double totalRobers = numOfStudents * priceOfRobes;
            double totalLightsabers = priceOfLightsabers * Math.Ceiling(numOfStudents + 0.10 * numOfStudents);
            double totalBelts = priceOfBelts * (numOfStudents - freeBelt);
            total = totalRobers + totalLightsabers + totalBelts;

            if (total > money)
            {
                Console.WriteLine($"Ivan Cho will need {Math.Abs(money - total):F2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }

        }
    }
}
