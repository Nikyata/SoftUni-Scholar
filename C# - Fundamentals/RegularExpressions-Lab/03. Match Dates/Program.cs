using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})(?<separator>\.|\-|\/)(?<month>[A-Z][a-z]{2})\'separator'(?<year>\d{4})\b";
            string input = Console.ReadLine();
            foreach (Match match in Regex.Matches(input, pattern))
            {
                Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
            }
        }
    }
}
