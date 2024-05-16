using System.Runtime.CompilerServices;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int quantity = 0;
            Dictionary<string, int> result = new Dictionary<string, int>();
            while ((input = Console.ReadLine().Trim()) != "stop")
            {

                    quantity = int.Parse(Console.ReadLine().Trim());
                    if (result.ContainsKey(input))
                    {
                    result[input] += quantity;
                    }
                    else
                    {
                    result.Add(input, quantity);
                    }
            }

            foreach (var element in result)
            {
            Console.WriteLine($"{element.Key} -> {element.Value}");
                
            }
        }
    }
}
