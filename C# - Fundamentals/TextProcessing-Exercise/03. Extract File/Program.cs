namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int lastDashIndex = input.LastIndexOf('\\');
            string fullName = input.Substring(lastDashIndex + 1);
            int lastDotIndex = fullName.LastIndexOf(".");
            string extension = fullName.Substring(lastDotIndex + 1);
            string name = fullName.Substring(0, lastDotIndex);
            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
