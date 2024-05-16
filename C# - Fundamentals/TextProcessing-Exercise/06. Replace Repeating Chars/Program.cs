using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            int index = 0;
            while (index < text.Length)
            {
                while (index + 1 < text.Length && text[index] == text[index + 1])
                {
                    index++;
                }
            sb.Append(text[index]);
            index++;
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
