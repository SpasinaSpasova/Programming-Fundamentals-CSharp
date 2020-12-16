using System;
using System.Collections.Specialized;
using System.Threading;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int powerN = int.Parse(Console.ReadLine());
            int power = powerN;

            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());
            int count = 0;

            while (distanceM <= powerN)
            {
                powerN -= distanceM;
                count++;
                if (powerN == power / 2)
                {
                    if (powerN != 0 && exhaustionFactorY != 0)
                    {
                        powerN = powerN / exhaustionFactorY;

                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(powerN);
            Console.WriteLine(count);
        }
    }
}
