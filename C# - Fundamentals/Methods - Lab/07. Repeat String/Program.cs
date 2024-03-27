
using System.Text;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string result = RepeatString(text, count);
            Console.WriteLine(result);
        }

        private static string RepeatString(string text, int count)
        {
            StringBuilder sb = new StringBuilder();
                for (int i = 0; i < count; i++)
                {
                    sb.Append(text);
                }
                return sb.ToString();
            
        }
    }
}
