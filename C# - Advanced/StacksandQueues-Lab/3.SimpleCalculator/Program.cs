namespace _3.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                stack.Push(input[i]);
            }
            int currentResult = 0;
            currentResult = int.Parse(stack.Pop());
            while (stack.Count > 0)
            {
                string operation = stack.Pop();
                if (operation == "+")
                {
                    currentResult += int.Parse(stack.Pop());
                }
                else
                {
                    currentResult -= int.Parse(stack.Pop());
                }
            }

            Console.WriteLine(currentResult);
        }
    }
}
