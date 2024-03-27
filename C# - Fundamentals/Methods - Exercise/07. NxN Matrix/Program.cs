namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintNxNMatrix(n);
        }

        private static void PrintNxNMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    Console.Write(n + " ");
                    
                }
                Console.WriteLine(n);
            }
        }
    }
}
