namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Random rnd = new Random();
            int rndNum = rnd.Next(input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];
                input[i] = input[rndNum];
                input[rndNum] = word;

            }

            foreach (var word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}
