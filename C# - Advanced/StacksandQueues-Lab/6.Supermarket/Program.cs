namespace _6.Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Queue<string> queue = new Queue<string>();
            int customerCount = 0;
            while ((input = Console.ReadLine()) != "End")
            {
                if (input != "Paid")
                {
                    queue.Enqueue(input);
                    customerCount++;
                }
                else
                {
                    for (int i = 0; i < customerCount; i++)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                     customerCount = 0;
                }
            }

            Console.WriteLine($"{customerCount} people remaining.");
        }
    }
}
