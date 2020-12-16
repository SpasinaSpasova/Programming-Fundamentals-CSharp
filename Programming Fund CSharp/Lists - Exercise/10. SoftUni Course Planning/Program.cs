using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessonsAndExercises = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string[] command = Console.ReadLine()
                .Split(":", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (command[0] != "course start")
            {

                if (command[0] == "Add")
                {
                    if (!(lessonsAndExercises.Contains(command[1])))
                    {
                        lessonsAndExercises.Add(command[1]);
                    }
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[2]);
                    if (index < 0 || index > lessonsAndExercises.Count - 1)
                    {
                        index = 0;
                    }
                    if (!(lessonsAndExercises.Contains(command[1])))
                    {
                        lessonsAndExercises.Insert(index, command[1]);
                    }
                }
                else if (command[0] == "Remove")
                {
                    if (lessonsAndExercises.Contains(command[1]))
                    {
                        lessonsAndExercises.Remove(command[1]);

                        if (lessonsAndExercises.Contains($"{command[1]}-Exercise"))
                        {
                            int index = lessonsAndExercises.IndexOf($"{command[1]}-Exercise");
                            lessonsAndExercises.RemoveAt(index);
                        }
                    }
                }
                else if (command[0] == "Swap")
                {
                    if (lessonsAndExercises.Contains(command[1]) && lessonsAndExercises.Contains(command[2]))
                    {
                        string first = command[1];
                        string second = command[2];
                        int indexOfFirst = lessonsAndExercises.IndexOf(first);
                        int indexOfSecond = lessonsAndExercises.IndexOf(second);

                        lessonsAndExercises.Remove(first);
                        lessonsAndExercises.Insert(indexOfFirst, second);
                        lessonsAndExercises.RemoveAt(indexOfSecond);
                        lessonsAndExercises.Insert(indexOfSecond, first);

                        if (lessonsAndExercises.Contains($"{command[1]}-Exercise"))
                        {
                            int index = lessonsAndExercises.IndexOf($"{command[1]}-Exercise");
                            lessonsAndExercises.Remove($"{command[1]}-Exercise");
                            lessonsAndExercises.Insert(indexOfFirst + 1, $"{command[1]}-Exercise");
                        }
                        else if (lessonsAndExercises.Contains($"{command[2]}-Exercise"))
                        {
                            int index = lessonsAndExercises.IndexOf($"{command[2]}-Exercise");
                            lessonsAndExercises.Remove($"{command[2]}-Exercise");
                            lessonsAndExercises.Insert(indexOfFirst + 1, $"{command[2]}-Exercise");
                        }
                    }
                }
                else if (command[0] == "Exercise")
                {
                    if (!(lessonsAndExercises.Contains(command[1])))
                    {
                        lessonsAndExercises.Add(command[1]);
                        lessonsAndExercises.Add($"{command[1]}-Exercise");
                    }
                    else
                    {
                        if (!(lessonsAndExercises.Contains($"{command[1]}-Exercise")))
                        {
                            lessonsAndExercises.Insert(lessonsAndExercises.IndexOf(command[1]) + 1, $"{command[1]}-Exercise");

                        }
                    }
                }


                command = Console.ReadLine()
                .Split(":", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
            for (int i = 0; i < lessonsAndExercises.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessonsAndExercises[i]}");
            }
        }
    }
}
