namespace _03.Largest3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var sortedList = numbers.OrderByDescending(x => x).Take(3).ToList();
            Console.WriteLine($"{string.Join(" ", sortedList)}");
        }
    }
}
