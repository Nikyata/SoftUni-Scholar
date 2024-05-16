using static System.Reflection.Metadata.BlobBuilder;

namespace _8.Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());



            int[,] matrix = new int[size, size];

            FillMatrix(matrix);

            string[] inputCoordinates = Console.ReadLine().Split();

            for (int i = 0; i < inputCoordinates.Length; i++)
            {
                string[] bombCoordinate = inputCoordinates[i].Split(",");
                int bombRow = int.Parse(bombCoordinate[0]);
                int bombCol = int.Parse(bombCoordinate[1]);
                int bombPower = matrix[bombRow, bombCol];

                if (bombPower > 0)
                {

                    // Нагоре
                    if (isValid(matrix, bombRow - 1, bombCol) && matrix[bombRow - 1, bombCol] > 0 &&
                        matrix[bombRow, bombCol] > 0)
                    {
                        TakeStep(matrix, bombRow - 1, bombCol, bombPower);
                    }

                    //Надясно
                    if (isValid(matrix, bombRow, bombCol + 1) && matrix[bombRow, bombCol + 1] > 0 &&
                        matrix[bombRow, bombCol] > 0)
                    {
                        TakeStep(matrix, bombRow, bombCol + 1, bombPower);
                    }

                    //Надолу
                    if (isValid(matrix, bombRow + 1, bombCol) && matrix[bombRow + 1, bombCol] > 0 &&
                        matrix[bombRow, bombCol] > 0)
                    {
                        TakeStep(matrix, bombRow + 1, bombCol, bombPower);
                    }

                    //Наляво
                    if (isValid(matrix, bombRow, bombCol - 1) && matrix[bombRow, bombCol - 1] > 0 &&
                        matrix[bombRow, bombCol] > 0)
                    {
                        TakeStep(matrix, bombRow, bombCol - 1, bombPower);
                    }

                    // Нагоре и Наляво
                    if (isValid(matrix, bombRow - 1, bombCol - 1) && matrix[bombRow - 1, bombCol - 1] > 0 &&
                        matrix[bombRow, bombCol] > 0)
                    {
                        TakeStep(matrix, bombRow - 1, bombCol - 1, bombPower);
                    }
                    
                    //Нагоре и надясно
                    if (isValid(matrix, bombRow - 1, bombCol + 1) && matrix[bombRow - 1, bombCol + 1] > 0 &&
                        matrix[bombRow, bombCol] > 0)
                    {
                        TakeStep(matrix, bombRow - 1, bombCol + 1, bombPower);
                    }
                    
                    //Надолу и надясно
                    if (isValid(matrix, bombRow + 1, bombCol + 1) && matrix[bombRow + 1, bombCol + 1] > 0 &&
                        matrix[bombRow, bombCol] > 0)
                    {
                        TakeStep(matrix, bombRow + 1, bombCol + 1, bombPower);
                    }
                   
                    //Надолу и наляво
                    if (isValid(matrix, bombRow + 1, bombCol - 1) && matrix[bombRow + 1, bombCol - 1] > 0 &&
                        matrix[bombRow, bombCol] > 0)
                    {
                        TakeStep(matrix, bombRow + 1, bombCol - 1, bombPower);
                    }
                    

                    matrix[bombRow, bombCol] = 0;
                }
            }


            int aliveCellsCounter = 0;
            int aliveCellsSum = 0;
            foreach (int item in matrix)
            {
                if (item > 0)
                {
                    aliveCellsCounter++;
                    aliveCellsSum += item;
                }
            }

            Console.WriteLine($"Alive cells: {aliveCellsCounter}");
            Console.WriteLine($"Sum: {aliveCellsSum}");
            PrintMatrix(matrix);


        }

        private static int TakeStep(int[,] matrix, int bombRow, int bombCol, int bombPower)
        {
            return matrix[bombRow, bombCol] -= bombPower;
        }

        private static bool isValid(int[,] matrix, int bombRow, int bombCol)
        {
            return bombRow >= 0 && bombRow < matrix.GetLength(0) &&
                bombCol >= 0 && bombCol < matrix.GetLength(1);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
