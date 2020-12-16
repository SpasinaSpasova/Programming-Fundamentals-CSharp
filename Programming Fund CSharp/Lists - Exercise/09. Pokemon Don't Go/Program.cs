using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();
            int sum = 0;
            while (sequence.Count > 0)
            {
                int indexToRemove = int.Parse(Console.ReadLine());
                int removeElementIncrease = 0;
                int removeElementDecrease = 0;
                if (indexToRemove < 0)
                {
                    indexToRemove = 0;
                    sum += sequence[indexToRemove];
                    removeElementIncrease = sequence[indexToRemove];
                    removeElementDecrease = sequence[indexToRemove];
                    sequence.RemoveAt(indexToRemove);
                    sequence.Insert(0, sequence[sequence.Count - 1]);
                    
                }
                else if (indexToRemove > sequence.Count - 1)
                {
                    sum += sequence[sequence.Count - 1];
                    removeElementIncrease = sequence[sequence.Count - 1];
                    removeElementDecrease = sequence[sequence.Count - 1];
                    sequence.RemoveAt(sequence.Count - 1);
                    sequence.Add(sequence[0]);

                }
                else
                {
                    sum += sequence[indexToRemove];
                    removeElementIncrease = sequence[indexToRemove];
                    removeElementDecrease = sequence[indexToRemove];
                    sequence.RemoveAt(indexToRemove);

                }


                for (int i = 0; i < sequence.Count; i++)
                {

                    if (sequence[i] <= removeElementIncrease)
                    {
                        sequence[i] += removeElementIncrease;
                    }
                    else if (sequence[i] >= removeElementDecrease)
                    {
                        sequence[i] -= removeElementDecrease;
                    }
                }


            }

            Console.WriteLine(sum);
        }
    }
}
