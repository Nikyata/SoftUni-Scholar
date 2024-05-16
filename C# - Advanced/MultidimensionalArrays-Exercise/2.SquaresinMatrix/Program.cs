namespace _2.SquaresinMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            int squareCounter = 0;
            string[,] matrix = ReadMatrix(rows, cols, " ");

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] && matrix[row + 1, col] == matrix[row + 1, col + 1] && matrix[row, col] == matrix[row+1, col + 1])
                    {
                        squareCounter++;
                    }
                }
            }

            Console.WriteLine(squareCounter);
            string[,] ReadMatrix(int rows, int cols, string separator)
            {
                string[,] matrix = new string[rows, cols];

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    string[] rowArray = Console.ReadLine().Split(separator).ToArray();
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = rowArray[col];
                    }
                }

                return matrix;
            }
        }
    }
}
