namespace _4.MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            string[,] matrix = new string[rows,cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowArray[col];
                }
            }

            string input = "";
            while ((input = Console.ReadLine()) != "END")
            {
                string[] commands = input.Split();
                string command = commands[0];
                if (commands.Length != 5)
                {
                    Console.WriteLine("Invalid input!");

                    continue;
                }
                if (command == "swap")
                {
                    int rowOne = int.Parse(commands[1]);
                    int colOne = int.Parse(commands[2]);
                    int rowTwo = int.Parse(commands[3]);
                    int colTwo = int.Parse(commands[4]);

                    if (isIndexValid(rowOne, matrix, colOne, rowTwo, colTwo))
                    {
                        string temp = matrix[rowOne,colOne];
                        matrix[rowOne,colOne] = matrix[rowTwo,colTwo];
                        matrix[rowTwo,colTwo] = temp;

                        PrintMatrix(matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }

        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }

                Console.WriteLine();
            }
        }

        private static bool isIndexValid(int rowOne, string[,] matrix, int colOne, int rowTwo, int colTwo)
        {
            return rowOne >= 0 && rowOne < matrix.GetLength(0) && colOne >= 0 && colOne < matrix.GetLength(1) &&
                   rowTwo >= 0 && rowTwo < matrix.GetLength(0) && colTwo >= 0 && colTwo < matrix.GetLength(1);
        }

    }
}
