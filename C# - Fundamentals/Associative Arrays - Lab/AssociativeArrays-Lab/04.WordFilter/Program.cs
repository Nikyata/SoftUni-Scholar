namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(Environment.NewLine, Console.ReadLine().Split().Where(w => w.Length % 2 == 0).ToArray()));
            
        }
    }
}
