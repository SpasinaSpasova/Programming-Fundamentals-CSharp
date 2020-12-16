using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<People> result = new List<People>();
            while (input != "End")
            {
                string[] info = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                People person = new People(info[0], info[1], int.Parse(info[2]));

                result.Add(person);

                input = Console.ReadLine();
            }
            List<People> sort = result.OrderBy(x => x.Age).ToList();

            foreach (People item in sort)
            {
                Console.WriteLine($"{item.Name} with ID: {item.ID} is {item.Age} years old.");
            }
        }
        class People
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }

            public People(string name, string id, int age)
            {
                this.Name = name;
                this.ID = id;
                this.Age = age;
            }


        }
    }
}
