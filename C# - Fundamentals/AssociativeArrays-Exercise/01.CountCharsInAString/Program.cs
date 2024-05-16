namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Dictionary<char, int> words = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    char letter = input[i][j];
                    if (!words.ContainsKey(letter))
                    {
                        words.Add(letter, 1);
                    }
                    else
                    {
                        words[letter]++;
                    }
                }
            }

            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} -> {word.Value}");
            }
        }
    }
}
