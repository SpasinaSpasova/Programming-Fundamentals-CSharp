using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int thePositive = Math.Abs(number);

            Console.WriteLine($"{GetMultipleOfEvenAndOdds(thePositive)}");
        }

        static int GetSumOfOddDigits(int digit)
        {
            int sumOdd = 0;
            while (digit>0)
            {
                int theNum = digit % 10;
                digit /= 10;
                if (theNum%2!=0)
                {
                    sumOdd += theNum;
                }
            }
            return sumOdd;
            
        }

        static int GetSumOfEvenDigits(int digit)
        {
            int sumEven = 0;
            while (digit > 0)
            {
                int theNum = digit % 10;
                digit /= 10;
                if (theNum % 2 == 0)
                {
                    sumEven += theNum;
                }
            }
            return sumEven;
        }

        static int GetMultipleOfEvenAndOdds(int digit)
        {
            GetSumOfOddDigits(digit);
            GetSumOfEvenDigits( digit);
            return GetSumOfOddDigits(digit) * GetSumOfEvenDigits(digit);
        }


    }
}
