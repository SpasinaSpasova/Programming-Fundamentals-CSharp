using System;
using System.Linq;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                long[] arr = Console.ReadLine()
                    .Split()
                    .Select(long.Parse)
                    .ToArray();

                long num1 = arr[0];
                long num2 = arr[1];

                string num1ToStr = num1.ToString();
                string num2ToStr = num2.ToString();
                long sum1 = 0;
                long sum2 = 0;

                if (num1 > num2)
                {

                    num1 = Math.Abs(num1);

                    for (int firstNum = 0; firstNum < num1ToStr.Length; firstNum++)
                    {
                        long current1 = num1 % 10;
                        sum1 += current1;
                        if (num1 > 0)
                        {
                            num1 /= 10;

                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.WriteLine(sum1);
                }
                else
                {

                    num2 = Math.Abs(num2);

                    for (int secondNum = 0; secondNum < num2ToStr.Length; secondNum++)
                    {
                        long current2 = num2 % 10;
                        sum2 += current2;
                        if (num2 > 0)
                        {
                            num2 /= 10;

                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.WriteLine(sum2);
                }

            }


        }
    }
}

