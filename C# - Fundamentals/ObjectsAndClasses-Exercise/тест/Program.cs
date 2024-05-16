namespace тест
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 6, 7, 7, 7, 8, 8 };
           var counter = numbers.Count(n => n == 7);
           Console.WriteLine(counter);
        }
    }
}
