
namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while ((input = Console.ReadLine()) != "end")
            {
                var reversed = input.Reverse();
                global::System.Console.WriteLine(reversed);
               
            }
        }
    }
}
