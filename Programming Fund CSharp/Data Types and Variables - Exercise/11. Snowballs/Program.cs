using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfSnowball = int.Parse(Console.ReadLine());

            BigInteger theBestValue = 0;
            int theBestSnow = 0;
            int theBestTime = 0;
            int theBestQuality = 0;

            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;
            BigInteger snowballValue = 0;

            BigInteger devide = 0;

            for (int i = 1; i <= numOfSnowball; i++)
            {
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());
                devide = snowballSnow / snowballTime;
                snowballValue = BigInteger.Pow(devide,snowballQuality);

                if (snowballValue >= theBestValue)
                {
                    theBestValue = snowballValue;
                    theBestSnow = snowballSnow;
                    theBestTime = snowballTime;
                    theBestQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{theBestSnow} : {theBestTime} = {theBestValue} ({theBestQuality})");
        }
    }
}
