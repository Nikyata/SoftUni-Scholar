using System.Net;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> result = new List<string>();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                List<string> currentList = list[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                
                    result.AddRange(currentList);
                    
                
               
            }
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
