namespace _1.DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstDiag = 0;
            int secondDiag = 0;

            for (int i = 0; i < n; i++)
            {
                int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();
                firstDiag += row[i];
                secondDiag += row[n - 1 - i];
            }

            Console.WriteLine(Math.Abs(firstDiag - secondDiag));

        }
    }
}
