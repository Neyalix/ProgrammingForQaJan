using System.ComponentModel;

namespace _02.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] articleNews = Console.ReadLine()
                                          .Split(", ");

            string title = articleNews[0];
            string content = articleNews[1];
            string author = articleNews[2];

            Article article = new Article(title, content, author);


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine()
                                         .Split(": ");

                string command = cmdArg[0];
                string par = cmdArg[1];

                if (command == "Edit")
                {
                    article.Edit(par);
                }
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(par);
                }
                else if (command == "Rename")
                {
                    article.Rename(par);
                }
            }

            Console.WriteLine(article.ToString());
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

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string changeAuthor)
        {
            Author = changeAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
