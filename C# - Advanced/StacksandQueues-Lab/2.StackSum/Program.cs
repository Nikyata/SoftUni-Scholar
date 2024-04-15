namespace _2.StackSum
{
    internal class Program
    {
        static void Main()
        {
            Stack<int> numbers = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            string input = "";
            while ((input = Console.ReadLine()).ToLower() != "end")
            {
                string[] args = input.Split();
                string command = args[0].ToLower();
                int firstNum = int.Parse(args[1]);
                if (command == "add")
                {
                    int secondNum = int.Parse(args[2]);
                    numbers.Push(firstNum);
                    numbers.Push(secondNum);
                }
                else
                {
                    if (numbers.Count >= firstNum)
                    {
                    for (int i = 0; i < firstNum; i++)
                    {
                        numbers.Pop();
                    }
                    }
                }
            }

            Console.WriteLine($"Sum: {numbers.Sum()}");
        }
    }
}
