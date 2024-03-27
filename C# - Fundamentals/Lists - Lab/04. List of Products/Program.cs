namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            List<string> result = new List<string>();
            for (int i = 0; i < n; i++)
            {
                result.Add(Console.ReadLine());
            
            }
            result.Sort();
            for (int j = 0; j < result.Count; j++)
            {
                
            Console.WriteLine($"{j+ 1}.{string.Join(" ", result[j])}");
            }
        }
    }
}
