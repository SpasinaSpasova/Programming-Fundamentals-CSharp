using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> article = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            int n = int.Parse(Console.ReadLine());

            Article theRes = new Article(article[0], article[1], article[2]);

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "Edit")
                {

                    theRes.Edit(command[1]);

                }
                else if (command[0] == "ChangeAuthor")
                {
                    theRes.ChangeAuthor(command[1]);
                }
                else if (command[0] == "Rename")
                {
                    theRes.Rename(command[1]);
                }
            }

            Console.WriteLine($"{theRes.Title} - {theRes.Content}: {theRes.Author}");
        }

        class Article
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public Article(string title, string content, string author)
            {
                this.Title = title;
                this.Content = content;
                this.Author = author;
            }

            public string Edit(string command)
            {
              return  this.Content = command;

            }
            public string ChangeAuthor(string command)
            {
                return this.Author = command;

            }

            public string Rename(string command)
            {
                return this.Title = command;

            }
        }
    }
}
