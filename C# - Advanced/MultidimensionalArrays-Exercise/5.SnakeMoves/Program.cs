namespace _5.SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            string snake = Console.ReadLine();

            char[,] matrix = new char[rows, cols];


            bool isLeftOrRight = true;

            int counter = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (isLeftOrRight)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snake[counter++];

                        if(counter == snake.Length)
                        {
                            counter = 0;
                        }
                    }

                    isLeftOrRight = false;
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >=0; col--)
                    {
                        matrix[row, col] = snake[counter++];

                        if (counter == snake.Length)
                        {
                            counter = 0;
                        }
                    }

                    isLeftOrRight = true;
                }
            }

            PrintMatrix(rows, cols, matrix);
        }

        private static void PrintMatrix(int rows, int cols, char[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
