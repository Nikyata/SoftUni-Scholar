namespace _5.PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            List<int> evenNums = new List<int>();
            while (numbers.Count > 0)
            {
                int currentNum = numbers.Dequeue();
                if (currentNum % 2 == 0)
                {
                    evenNums.Add(currentNum);
                }
            }

            Console.WriteLine(string.Join(", ", evenNums));
        }
    }
}
