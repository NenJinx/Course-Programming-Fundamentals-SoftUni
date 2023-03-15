
namespace Articles
{
    using System;
    using System.Data;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Mime;
    using System.Text;
    using System.Threading.Tasks;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] separator = { ": " };
            string[] separatorOne = { ", " };
            string[] initialArticle = Console.ReadLine().Split(separatorOne, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(Console.ReadLine());
            string titleArticle = initialArticle[0];
            string contentArticle = initialArticle[1];
            string authorArticle = initialArticle[2];
            Article obj = new Article(titleArticle, contentArticle, authorArticle);
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).
                    ToArray();
                string commandName = cmdArgs[0];

                if (commandName == "Edit")
                {
                    string newArticle = cmdArgs[1];
                    obj.EditArticle(newArticle);
                }
                else if (commandName == "ChangeAuthor")
                {
                    string newAuthor = cmdArgs[1];
                    obj.ChangeAuthor(newAuthor);
                }
                else
                {
                    string newTitle = cmdArgs[1];
                    obj.RenameTitle(newTitle);
                }
            }
            Console.WriteLine($"{obj.Title} - {obj.Content}: {obj.Author}");
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
        public string Title { get; private set; }
        public string Content { get; private set; }
        public string Author { get; private set; }

        public void EditArticle(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void RenameTitle(string newTitle)
        {
            Title = newTitle;
        }




    }
}
