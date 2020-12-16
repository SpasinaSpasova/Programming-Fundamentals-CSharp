using System;
using System.Xml.Schema;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int  number = int.Parse(Console.ReadLine());

            int tempNum = number;//zapazwam si number

            string strNum = "";//za da vzema dyljinata na number
            strNum += number;

            int total = 0;

            for (int i = 0; i < strNum.Length; i++)
            {
                int currentDigit = tempNum % 10;
                tempNum /= 10;
          
                int fact = 1;
                for (int j = 1; j <= currentDigit; j++)
                {
                    fact *= j;
                    
                }
                total += fact;
            }
          
            if (number==total)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
