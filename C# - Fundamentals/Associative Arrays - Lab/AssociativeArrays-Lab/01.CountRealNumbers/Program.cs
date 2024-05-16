namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            SortedDictionary<int, int> counts = new SortedDictionary<int, int>();
            foreach (int number in numbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts[number] = 1;
                }
            }

            foreach (var num in counts)
            {
                Console.WriteLine($"{num.Key} - {num.Value}");
            }
        }
    }
}
