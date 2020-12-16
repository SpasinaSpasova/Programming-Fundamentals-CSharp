using System;
using System.Xml.Schema;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int countOfSrings = int.Parse(Console.ReadLine());

            int[] result = new int[countOfSrings];

            for (int i = 0; i < countOfSrings; i++)
            {
                string sequence = Console.ReadLine();

                char[] arr = sequence.ToCharArray();

                int sumVo = 0;
                int sumCo = 0;
                int total = 0;

                for (int j = 0; j < arr.Length; j++)
                {


                    if (arr[j] == 'a' ||
                        arr[j] == 'e' ||
                        arr[j] == 'o' ||
                        arr[j] == 'u' ||
                        arr[j] == 'i' ||
                         arr[j] == 'A' ||
                          arr[j] == 'O' ||
                           arr[j] == 'U' ||
                            arr[j] == 'E' ||
                             arr[j] == 'I' )
                    {
                        sumVo += arr[j]*arr.Length ;
                    }
                    else
                    {
                        sumCo += arr[j]/arr.Length ;
                    }

                }

                total = sumVo + sumCo;

                result[i] += total;



            }

            Array.Sort(result);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
          
        }
    }
}
