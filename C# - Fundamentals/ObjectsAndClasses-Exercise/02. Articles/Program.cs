namespace _02._Articles
{
    internal class Program
    {
        static void Main()
        {
            string[] articleStr = Console.ReadLine().Split(", ");
            int n = int.Parse(Console.ReadLine());

            Article NewArticle = new Article(articleStr[0], articleStr[1], articleStr[2]);
            for (int i = 0; i < n; i++)
            {
                articleStr = Console.ReadLine().Split(": ");

                switch (articleStr[0])
                {
                    case "Edit":
                        NewArticle.editContent(articleStr[1]);
                        break;
                    case "ChangeAuthor":
                        NewArticle.editAuthor(articleStr[1]);
                        break;
                    case "Rename":
                        NewArticle.editTitle(articleStr[1]);
                        break;
                }

            }

            Console.WriteLine(NewArticle);

        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        private string Title { get; set; }
        private string Content { get; set; }
        private string Author { get; set; }

        public void editContent(string newContent)
        {
            Content = newContent;
        }
        public void editAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void editTitle(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}