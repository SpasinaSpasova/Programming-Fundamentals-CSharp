using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal savings = decimal.Parse(Console.ReadLine());

            List<int> drumSet = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> theOrigin = drumSet.ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);
                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] -= hitPower;
                }
                for (int i = 0; i < drumSet.Count; i++)
                {
                    if (drumSet[i] <= 0)
                    {
                        if ((savings - theOrigin[i] * 3) > 0)
                        {
                            savings -= theOrigin[i] * 3;

                            drumSet[i] = theOrigin[i];

                        }
                        else
                        {
                            drumSet.RemoveAt(i);
                            theOrigin.RemoveAt(i);
                        }
                    }
                    //if (drumSet[i] <= 0)
                    //{
                    //    drumSet.RemoveAt(i);
                    //    theOrigin.RemoveAt(i);
                    //}



                }
            }
            Console.WriteLine(string.Join(" ", drumSet));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
