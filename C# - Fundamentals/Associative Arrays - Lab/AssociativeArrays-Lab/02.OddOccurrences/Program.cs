namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputWords = Console.ReadLine().Split();
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var word in inputWords)
            {
                var currentWord = word.ToLower();
                if(counts.ContainsKey(currentWord))
                {
                    counts[currentWord]++;
                }
                else
                {
                    counts.Add(currentWord, 1);
                }
            }

            foreach (var values in counts)
            {
                if(values.Value % 2 == 1)
                {
                    Console.Write(values.Key + " ");
                }
            }
            
        }
    }
}
