using System;
using System.Linq;
using System.Text;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < usernames.Length; i++)
            {
                string current = usernames[i];
                bool isValid = true;


                if (current.Length >= 3 && current.Length <= 16)
                {
                    for (int j = 0; j < current.Length; j++)
                    {
                        if (!(char.IsLetter(current[j])
                        || char.IsDigit(current[j])
                        || current[j] == '_'
                        || current[j] == '-'))
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        result.AppendLine(current);
                    }
                }

            }
            Console.WriteLine(result);
        }
    }
}
