using System;
using System.Collections.Generic;

namespace _05._Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string HomeTown { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Student> result = new List<Student>();

            while (input!="end")
            {
                string[] information = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = information[0];
                string lastName = information[1];
                string age = information[2];
                string homeTown = information[3];

                Student student = new Student();

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.HomeTown = homeTown;

                result.Add(student);


                input = Console.ReadLine();
            }

            string town = Console.ReadLine();
            foreach (Student item in result)
            {
                if (item.HomeTown==town)
                {
                    Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");
                }
            }

        }

    }
}
