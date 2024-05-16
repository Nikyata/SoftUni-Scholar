using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359(\s|\-)2\1\d{3}(\s|\-)\d{4}(?!\d)";
            string input = Console.ReadLine();

           var matches = Regex.Matches(input, pattern);
           Console.WriteLine(string.Join(", ", matches.Select(x => x.Groups[0])));
        }
    }
}
