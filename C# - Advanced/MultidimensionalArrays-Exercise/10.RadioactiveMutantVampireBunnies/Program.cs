using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace _10.RadioactiveMutantVampireBunnies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = size[0];
            int cols = size[1];

            char[,] map = new char[rows, cols];
            // 1. Попълване на първоначалната карта

            int playerRow = 0;
            int playerCol = 0;
            for (int row = 0; row < map.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < map.GetLength(1); col++)
                {
                    map[row, col] = input[col];
                    if (map[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            // 2. Взиамем посоките на играча
            string directions = Console.ReadLine();

            bool hasWon = false;
            bool hasLost = false;
            foreach (var direction in directions)
            {

                int nextRow = 0;
                int nextCol = 0;

                if (direction == 'L')
                {
                    nextCol = -1;
                }
                else if (direction == 'R')
                {
                    nextCol = 1;
                }
                else if (direction == 'U')
                {
                    nextRow = -1;
                }
                else if (direction == 'D')
                {
                    nextRow = 1;
                }



                map[playerRow, playerCol] = '.';

                if (!isInside(map, playerRow + nextRow, playerCol + nextCol))
                {
                    hasWon = true;
                }
                else
                {
                    playerRow += nextRow;
                    playerCol += nextCol;

                    if (isInside(map, playerRow, playerCol) && map[playerRow, playerCol] == 'B')
                    {
                        hasLost = true;

                    }
                    else
                    {
                        map[playerRow, playerCol] = 'P';

                    }
                }
                List<int[]> bunniesPositions = new List<int[]>();

                for (int row = 0; row < map.GetLength(0); row++)
                {
                    for (int col = 0; col < map.GetLength(1); col++)
                    {
                        if (map[row, col] == 'B')
                        {
                            bunniesPositions.Add(new int[] { row, col });

                        }
                    }
                }

                foreach (var bunny in bunniesPositions)
                {
                    int bunnyRow = bunny[0];
                    int bunnyCol = bunny[1];

                    // ред надолу
                    if (isInside(map, bunnyRow + 1, bunnyCol))
                    {
                        if (map[bunnyRow + 1, bunnyCol] == 'P')
                        {
                            hasLost = true;

                        }
                        map[bunnyRow + 1, bunnyCol] = 'B';
                    }
                    // ред нагоре
                    if (isInside(map, bunnyRow - 1, bunnyCol))
                    {
                        if (map[bunnyRow - 1, bunnyCol] == 'P')
                        {
                            hasLost = true;
                        }
                        map[bunnyRow - 1, bunnyCol] = 'B';
                    }
                    // колона надясно
                    if (isInside(map, bunnyRow, bunnyCol + 1))
                    {
                        if (map[bunnyRow, bunnyCol + 1] == 'P')
                        {
                            hasLost = true;

                        }
                        map[bunnyRow, bunnyCol + 1] = 'B';
                    }
                    // колона наляво
                    if (isInside(map, bunnyRow, bunnyCol - 1))
                    {
                        if (map[bunnyRow, bunnyCol - 1] == 'P')
                        {
                            hasLost = true;
                            //break;
                        }
                        map[bunnyRow, bunnyCol - 1] = 'B';
                    }

                }
                if (hasWon)
                {
                    PrintMap(map);

                    if (playerRow < 0)
                    {
                        playerRow = 0;
                    }

                    if (playerCol < 0)
                    {
                        playerCol = 0;
                    }

                    Console.WriteLine($"won: {playerRow} {playerCol}");
                    Environment.Exit(0);
                }
                else if (hasLost)
                {
                    PrintMap(map);
                    Console.WriteLine($"dead: {playerRow} {playerCol}");
                    Environment.Exit(0);
                }
            }
        }
            private static void PrintMap(char[,] map)
            {
                for (int row = 0; row < map.GetLength(0); row++)
                {
                    for (int col = 0; col < map.GetLength(1); col++)
                    {
                        Console.Write(map[row, col]);
                    }
                    Console.WriteLine();
                }
            }

            private static bool isInside(char[,] board, int row, int col)
            {
                return row >= 0 && row < board.GetLength(0) && col >= 0 && col < board.GetLength(1);
            }
        }
    }
