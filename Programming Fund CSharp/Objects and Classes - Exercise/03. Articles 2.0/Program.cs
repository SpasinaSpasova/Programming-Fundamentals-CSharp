using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());



            List<Article> theRes = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                List<string> article = Console.ReadLine()
               .Split(", ", StringSplitOptions.RemoveEmptyEntries)
               .ToList();

                Article theClass = new Article(article[0], article[1], article[2]);

                theRes.Add(theClass);

            }

            string command = Console.ReadLine();

            List<Article> sorted = new List<Article>();

            if (command == "title")
            {
                sorted = theRes.OrderBy(x => x.Title).ToList();
            }
            else if (command == "author")
            {
                sorted = theRes.OrderBy(x => x.Author).ToList();
            }
            else if (command == "content")
            {
                sorted = theRes.OrderBy(x => x.Content).ToList();
            }

            foreach (Article item in sorted)
            {
                Console.WriteLine($"{item.Title} - {item.Content}: {item.Author}");
            }
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
        }
    }
}
