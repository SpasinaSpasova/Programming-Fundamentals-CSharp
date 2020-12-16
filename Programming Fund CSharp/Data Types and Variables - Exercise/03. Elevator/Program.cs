using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            if (numOfPeople < capacity)
            {
                Console.WriteLine("1");//vsichki hora shte se kachat s edin kurs na asansiora
            }
            else
            {
                int fullCourses = numOfPeople / capacity;//delim za da widim pylnite kursowe
                int partially = numOfPeople % capacity;//ostatyka sa horata koito ne sa se kachili s pylnite kursove
                if (partially != 0&&partially<=capacity)
                {
                    fullCourses++;
                }
                Console.WriteLine(fullCourses);
            }






        }
    }
}
