﻿using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int rows = 1; rows <= n; rows++)
            {
                for (int cows = 1; cows <= rows; cows++)
                {
                    Console.Write(rows+" ");
                }

                Console.WriteLine("");
            }
        }
    }
}
