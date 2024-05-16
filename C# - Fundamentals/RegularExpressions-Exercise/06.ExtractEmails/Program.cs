using System.Text;
using System.Text.RegularExpressions;

namespace _06.ExtractEmails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[^\.\-_]\b(?![\._\-])[A-Za-z0-9]+[\.\-_]*[A-Za-z0-9]+@[^\.\-](?:[A-Za-z\.\-]+\.)+[A-Za-z]+";
            string input = Console.ReadLine();
            List<string> validEmails = new List<string>();
            foreach (Match match in Regex.Matches(input, pattern))
            {
                validEmails.Add(match.ToString());
            }
            foreach (var mail in validEmails)
            {
                Console.WriteLine(mail.TrimStart());
            }
        }
    }
}
