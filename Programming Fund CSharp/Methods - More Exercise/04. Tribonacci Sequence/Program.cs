using System;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] result = new int[num];

            if (num==0)
            {
                return;
            }
            if (num == 1)
            {
                result[0] = 1;

            }
            else
            {
            result[0] = 1;
            result[1] = 1;

            }


            for (int j = 3; j <= num; j++)
            {



                if (j - 4 >= 0)
                {
                    result[j - 1] = result[j - 2] + result[j - 3] + result[j - 4];
                }
                else
                {
                    result[j - 1] = result[j - 2] + result[j - 3];
                }
            }

            Console.WriteLine(string.Join(" ", result));

        }
    }
}

