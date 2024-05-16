namespace _02._Articles
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articleList = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                string[] articleStr = Console.ReadLine().Split(", ");
                Article article = new Article(articleStr[0], articleStr[1], articleStr[2]);
                articleList.Add(article);
            }

            foreach (var article in articleList)
            {
                Console.WriteLine(article);
            }
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