namespace _4.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (input[i] == ')')
                {
                    int openIndex = indexes.Pop();
                    int endIndex = i;
                    string substring = input.Substring(openIndex, endIndex - openIndex + 1);
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
