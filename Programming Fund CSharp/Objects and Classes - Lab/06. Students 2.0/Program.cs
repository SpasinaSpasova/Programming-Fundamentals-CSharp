using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Students_2._0
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

            while (input != "end")
            {
                string[] information = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = information[0];
                string lastName = information[1];
                string age = information[2];
                string homeTown = information[3];

                if (IsStudentExisting(result,firstName,lastName))
                {
                    Student toRewrite = GetStudent(result, firstName, lastName);
                    toRewrite.FirstName = firstName;
                    toRewrite.LastName = lastName;
                    toRewrite.Age = age;
                    toRewrite.HomeTown = homeTown;

                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = homeTown
                       
                    };
                    result.Add(student);
                }
                input = Console.ReadLine();
            }

            string town = Console.ReadLine();
            foreach (Student item in result)
            {
                if (item.HomeTown == town)
                {
                    Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");
                }
            }

        }

        static bool IsStudentExisting(List<Student> result,string firstName,string lastName)
        {
            foreach (Student item in result)
            {
                if (item.FirstName==firstName&&item.LastName==lastName)
                {
                    return true;
                }
            }
            return false;
        }
        static Student GetStudent(List<Student> result, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student item in result)
            {
                if (item.FirstName == firstName && item.LastName == lastName)
                {
                    existingStudent= item;
                }
            }
            return existingStudent;
        }
    }
}

