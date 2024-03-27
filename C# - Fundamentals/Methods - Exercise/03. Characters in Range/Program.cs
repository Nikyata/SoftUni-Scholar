namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startChar = char.Parse(Console.ReadLine());
            int endChar = char.Parse(Console.ReadLine());
            string result = PrintCharInRange(startChar, endChar);
            Console.WriteLine(result);
        }

        private static string PrintCharInRange(int startChar, int endChar)
        {
            string result = "";
            if (startChar > endChar)
            {
                for (int i = endChar + 1; i < startChar; i++)
                {
                    result += $"{(char)i} ";
                }
            }
            else if (endChar > startChar)
            {
                for (int i = startChar + 1; i < endChar; i++)
                {
                    result += $"{(char)i} ";
                }
            }
           

            return result;
        }
    }
}
