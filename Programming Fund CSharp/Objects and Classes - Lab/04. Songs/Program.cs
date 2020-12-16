using System;
using System.Collections.Generic;
using System.Threading;

namespace _04._Songs
{
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            List<Song> result = new List<Song>();

            for (int i = 0; i < num; i++)
            {
                string[] information = Console.ReadLine()
                    .Split("_", StringSplitOptions.RemoveEmptyEntries);

                string type = information[0];
                string name = information[1];
                string time = information[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                result.Add(song);
            }

            string lastLine = Console.ReadLine();

            if (lastLine=="all")
            {
                foreach (Song song in result)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in result)
                {
                    if (song.TypeList==lastLine)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }

        }
    }
}
