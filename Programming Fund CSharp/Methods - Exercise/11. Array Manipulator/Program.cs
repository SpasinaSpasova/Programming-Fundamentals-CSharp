using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                if (command[0] == "exchange")
                {
                    if (int.Parse(command[1]) < 0 || int.Parse(command[1]) >= array.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    Exchange(array, int.Parse(command[1]));
                }
                else if (command[0] == "max")
                {
                    if (command[1] == "even")
                    {

                        if (MaxEven(array) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }

                        Console.WriteLine(MaxEven(array));

                    }
                    else
                    {

                        if (MaxOdd(array) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }

                        Console.WriteLine(MaxOdd(array));

                    }
                }
                else if (command[0] == "min")
                {
                    if (command[1] == "even")
                    {

                        if (MinEven(array) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }

                        Console.WriteLine(MinEven(array));

                    }
                    else
                    {

                        if (MinOdd(array) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }

                        Console.WriteLine(MinOdd(array));

                    }
                }
                else if (command[0] == "first")
                {
                    if (int.Parse(command[1]) > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    if (command[2] == "even")
                    {
                        FirstEven(array, int.Parse(command[1]));
                    }
                    else
                    {
                        FirstOdd(array, int.Parse(command[1]));
                    }
                }
                else if (command[0] == "last")
                {
                    if (int.Parse(command[1]) > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    if (command[2] == "even")
                    {
                        LastEven(array, int.Parse(command[1]));
                    }
                    else
                    {
                        LastOdd(array, int.Parse(command[1]));
                    }
                }



            }

            Console.WriteLine("[" + string.Join(", ", array) + "]");


        }
        static void Exchange(int[] array, int index)
        {
            int[] firstArray = new int[array.Length - index - 1];
            int[] secondAray = new int[index + 1];

            int firstArrCounter = 0;
            for (int i = index + 1; i < array.Length; i++)
            {
                firstArray[firstArrCounter] = array[i];
                firstArrCounter++;

            }

            for (int i = 0; i < index + 1; i++)
            {
                secondAray[i] = array[i];
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                array[i] = firstArray[i];
            }


            for (int i = 0; i < secondAray.Length; i++)
            {
                array[firstArray.Length + i] = secondAray[i];

            }


        }

        static int MaxEven(int[] array)
        {
            int MaxEven = int.MinValue;
            int currentIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (array[i] >= MaxEven)
                    {
                        MaxEven = array[i];
                        currentIndex = i;
                    }
                }
            }

            return currentIndex;

        }

        static int MaxOdd(int[] array)
        {
            int MaxOdd = int.MinValue;
            int currentIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] >= MaxOdd)
                    {
                        MaxOdd = array[i];
                        currentIndex = i;
                    }
                }
            }

            return currentIndex;

        }

        static int MinEven(int[] array)
        {
            int MinEven = int.MaxValue;
            int currentIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (array[i] <= MinEven)
                    {
                        MinEven = array[i];
                        currentIndex = i;
                    }
                }
            }

            return currentIndex;

        }

        static int MinOdd(int[] array)
        {
            int minOdd = int.MaxValue;
            int currentIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] <= minOdd)
                    {
                        minOdd = array[i];
                        currentIndex = i;
                    }
                }
            }

            return currentIndex;

        }

        static void FirstEven(int[] array, int count)
        {
            int counterEven = 0;
            string numbers = string.Empty;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {


                    numbers += array[i] + " ";
                    counterEven++;


                }
                if (counterEven == count)
                {
                    break;
                }
            }
            var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (counterEven == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", result) + "]");

            }
        }

        static void FirstOdd(int[] array, int count)
        {
            int counterOdd = 0;
            string numbers = string.Empty;


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {


                    numbers += array[i] + " ";
                    counterOdd++;


                }

                if (counterOdd == count)
                {
                    break;
                }
            }
            var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (counterOdd == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", result) + "]");

            }


        }

        static void LastEven(int[] array, int count)
        {
            int counterEven = 0;

            string numbers = string.Empty;



            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 == 0)
                {

                    numbers += array[i] + " ";

                    counterEven++;


                }
                if (counterEven == count)
                {
                    break;
                }
            }
            var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (counterEven == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", result.Reverse()) + "]");

            }
        }

        static void LastOdd(int[] array, int count)
        {
            int counterOdd = 0;

            string numbers = string.Empty;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 != 0)
                {


                    numbers += array[i] + " ";
                    counterOdd++;


                }
                if (counterOdd == count)
                {
                    break;
                }
            }
            var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (counterOdd == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", result.Reverse()) + "]");

            }
        }
    }
}
