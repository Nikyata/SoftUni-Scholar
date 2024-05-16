using System.Reflection.PortableExecutable;
using System.Text;

namespace _01._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                var startNameIndex = line.IndexOf("@");
                var endNameIndex = line.IndexOf("|");
                var endOfName = endNameIndex - startNameIndex - 1;
                string name = line.Substring(startNameIndex + 1, endOfName);
                int startAgeIndex = line.IndexOf('#');
                int endAgeIndex = line.IndexOf('*');
                int endOfAge = endAgeIndex - startAgeIndex - 1;
                string age = line.Substring(startAgeIndex + 1, endOfAge);
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
