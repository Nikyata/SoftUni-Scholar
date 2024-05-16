namespace _05._HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();
            string comments = "";
            List<string> htmlCode = new List<string>();
            htmlCode.Add("<h1>");
            htmlCode.Add("\t" + title);
            htmlCode.Add("</h1>");
            htmlCode.Add("<article>");
            htmlCode.Add("\t" + content);
            htmlCode.Add("</article>");
            while ((comments = Console.ReadLine()) != "end of comments")
            {
                htmlCode.Add("<div>");
                htmlCode.Add("\t" + comments);
                htmlCode.Add("</div>");
            }

            foreach (var line in htmlCode)
            {
                Console.WriteLine(line);
            }
        }
    }
}
