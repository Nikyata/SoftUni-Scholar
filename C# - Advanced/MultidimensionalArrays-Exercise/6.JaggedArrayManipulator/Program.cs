namespace _6.JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            FillJaggedArray(rows, jaggedArray);

            for (int row = 0; row < jaggedArray.Length - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                        jaggedArray[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] /= 2;
                    }

                    for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                    {
                        jaggedArray[row + 1][col] /= 2;
                    }
                }
            }

            string input = "";

            while((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split();

                string command = arguments[0];
                int row = int.Parse(arguments[1]);
                int col = int.Parse(arguments[2]);
                int value = int.Parse(arguments[3]);


                if(!(row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length))
                {
                    continue;
                }
                

                if(command == "Add")
                {
                    jaggedArray[row][col] += value;
                }
                else if(command == "Subtract")
                {
                    jaggedArray[row][col] -= value;
                }
 
            }




            PrintJaggedArray(jaggedArray);

        }

        private static void PrintJaggedArray(int[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {

                Console.WriteLine(string.Join(" ", jaggedArray[row]));
            }
        }

        private static void FillJaggedArray(int rows, int[][] jaggedArray)
        {
            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[row] = input;
            }
        }
    }
}
