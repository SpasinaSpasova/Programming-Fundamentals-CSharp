using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                SecondLoop(number);
                
            }
        }

        static void SecondLoop(int num)
        {
            for (int i = 1; i <=num; i++)
            {
                Console.Write(num+ " ");
            }
            Console.WriteLine();
        }

        
    }
}
