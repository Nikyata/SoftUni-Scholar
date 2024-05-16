namespace _01.Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "";
            while((word = Console.ReadLine()) != "end")
            {
                string reverse = new string(word.Reverse().ToArray());
                Console.WriteLine($"{word} = {reverse}");
            }
        }
    }
}
