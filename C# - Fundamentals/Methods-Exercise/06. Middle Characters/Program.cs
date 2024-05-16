namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleChars(input);
        }

        private static void PrintMiddleChars(string input)
        {
            if (input.Length % 2 == 0)
            {
                Console.Write($"{(input[input.Length / 2 -1])}{(input[input.Length / 2])}  ");
            }
            else
            {
                Console.Write($"{(input[input.Length / 2])}");
            }
        }
    }
}
