using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] separator = { ": " };
            string[] separatorOne = { ", " };
            int n = int.Parse(Console.ReadLine());
            string command = "";
            List<Article> articles = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                //while ((command = Console.ReadLine()) != "title" || (command = Console.ReadLine()) != "content" ||
                //    (command = Console.ReadLine()) != "author")

                string[] cmdArgs = Console.ReadLine().Split(separatorOne, StringSplitOptions.RemoveEmptyEntries).
                    ToArray();
                string titleArticle = cmdArgs[0];
                string contentArticle = cmdArgs[1];
                string authorArticle = cmdArgs[2];
                var obj = new Article(titleArticle, contentArticle, authorArticle);
                articles.Add(obj);
            }
            string orderWay = Console.ReadLine();
            switch (orderWay)
            {
                case "title":
                    {
                        articles = articles.OrderBy(a => a.Title).ToList();
                        break;
                    }
                case "content":
                    {
                        articles = articles.OrderBy(a => a.Content).ToList();
                        break;
                    }
                case "author":
                    {
                        articles = articles.OrderBy(a => a.Author).ToList();
                        break;
                    }
            }
            Console.WriteLine(string.Join("\n", articles));
        }
    }
    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}



