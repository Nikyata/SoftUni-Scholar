using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<firstName>\b[A-Z][a-z]+) (?<lastName>\b[A-Z][a-z]+)";
            string input = Console.ReadLine();
            RegexOptions options = RegexOptions.Multiline;

            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.Write(m.Groups[0] + " ");
            }
        }
    }
}
