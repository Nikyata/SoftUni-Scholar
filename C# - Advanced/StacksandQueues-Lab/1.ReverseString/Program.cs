namespace _1.ReverseString
{
    internal class Program
    {
        static void Main()
        {
            Stack<char> word = new Stack<char>(Console.ReadLine().ToCharArray());
            while (word.Count != 0)
            {
                Console.Write(word.Pop());
            }
        }
    }
}
