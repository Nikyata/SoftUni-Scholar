using System.Text;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            StringBuilder result = new StringBuilder();
            foreach (string word in input)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result.Append(word);
                }

            }
                Console.WriteLine(result);
        }
    }
}
