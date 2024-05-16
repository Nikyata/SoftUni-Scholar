

using System;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = "";
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                switch (command[0])
                {
                    case "exchange":
                        int indexOfExchange = int.Parse(command[1]);
                        inputArr = ExchangeArraysMethod(inputArr, indexOfExchange);
                        break;
                    case "max":
                        if (command[1] == "odd")
                        {
                            MaxOdd(inputArr);
                        }
                        else if (command[1] == "even")
                        {
                            MaxEven(inputArr);
                        }

                        break;
                    case "min":
                        if (command[1] == "odd")
                        {
                            MinOdd(inputArr);
                        }
                        else if (command[1] == "even")
                        {
                            MinEven(inputArr);
                        }

                        break;
                    case "first":
                        if (command[2] == "even")
                        {
                            FirstEven(inputArr, int.Parse(command[1]));
                        }
                        else if (command[2] == "odd")
                        {
                            FirstOdd(inputArr, int.Parse(command[1]));
                        }

                        break;
                    case "last":
                        if (command[2] == "even")
                        {
                            LastEven(inputArr, int.Parse(command[1]));
                        }
                        else if (command[2] == "odd")
                        {
                            LastOdd(inputArr, int.Parse(command[1]));
                        }

                        break;
                }


            }

            Console.WriteLine($"[{string.Join(", ", inputArr)}]");
        }

        static int[] ExchangeArraysMethod(int[] inputArr, int index)
        {
            if (index < 0 || index > inputArr.Length - 1)
            {
                Console.WriteLine("Invalid index");
                return inputArr;
            }

            int[] changedArray = new int[inputArr.Length];
            int changedArrayIndex = 0;
            for (int i = index + 1; i <= inputArr.Length - 1; i++)
            {
                changedArray[changedArrayIndex] = inputArr[i];
                changedArrayIndex++;
            }

            for (int i = 0; i <= index; i++)
            {
                changedArray[changedArrayIndex] = inputArr[i];
                changedArrayIndex++;
            }


            return changedArray;

        }

        static void MaxOdd(int[] array)
        {
            int maxOddNum = int.MinValue;
            int maxOddNumIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] >= maxOddNum)
                    {
                        maxOddNum = array[i];
                        maxOddNumIndex = i;
                    }

                }

            }

            if (maxOddNumIndex != -1)
            {
                Console.WriteLine(maxOddNumIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void MinOdd(int[] array)
        {
            int minOddNum = int.MaxValue;
            int minOddNumIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] <= minOddNum)
                    {
                        minOddNum = array[i];
                        minOddNumIndex = i;
                    }

                }

            }

            if (minOddNumIndex != -1)
            {
                Console.WriteLine(minOddNumIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }

        }

        static void MaxEven(int[] array)
        {
            int maxEvenNum = int.MinValue;
            int maxEvenNumIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (array[i] >= maxEvenNum)
                    {
                        maxEvenNum = array[i];
                        maxEvenNumIndex = i;
                    }

                }

            }

            if (maxEvenNumIndex != -1)
            {
                Console.WriteLine(maxEvenNumIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }

        }

        static void MinEven(int[] array)
        {
            int minEvenNum = int.MaxValue;
            int minEvenNumIndex = 0;
            bool isFound = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (array[i] <= minEvenNum)
                    {
                        minEvenNum = array[i];
                        minEvenNumIndex = i;
                        isFound = true;
                    }

                }

            }

            if (!isFound)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minEvenNumIndex);
            }

        }

        static void FirstEven(int[] array, int count)
        {
            string evenNums = null;
            int elementsCount = 0;
            if (count > array.Length - 1)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                int number = array[i];

                if (array[i] % 2 == 0)
                {
                    evenNums += $"{number}, ";
                    elementsCount++;
                    if (elementsCount >= count)
                    {
                        break;
                    }
                }
            }

            if (evenNums == null)
            {
                Console.WriteLine("[]");
            }
            else
            {
                string result = evenNums.Trim(',', ' ');
                Console.WriteLine($"[{result}]");
            }

        }

        static void FirstOdd(int[] array, int count)
        {
            string oddNums = null;
            int elementsCount = 0;
            if (count > array.Length - 1)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            for (int i = 0; i < array.Length; i++)
            {
                int number = array[i];

                if (array[i] % 2 != 0)
                {
                    oddNums += $"{number}, ";
                    elementsCount++;
                    if (elementsCount >= count)
                    {
                        break;
                    }
                }
            }
                string result = oddNums.Trim(',', ' ');
                Console.WriteLine($"[{result}]");
        }

        static void LastOdd(int[] array, int count)
        {
            string oddNums = null;
            int elements = 0;
            if (count > array.Length - 1)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                int number = array[i];
                if (array[i] % 2 != 0)
                {
                    oddNums += $"{number}, " + oddNums;
                    elements++;
                    if (elements == count)
                    {
                        break;
                    }
                }
            }

            string result = oddNums.Trim(',', ' ');
            Console.WriteLine($"[{result}]");
        }

        static void LastEven(int[] array, int count)
        {
            
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            string evenNums = "";
            int elements = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int number = array[i];
                if (array[i] % 2 == 0)
                {
                    evenNums = $"{number}, " + evenNums;
                    elements++;
                    if (elements == count)
                    {
                        break;
                    }
                }
            }
                    string result = evenNums.Trim(',', ' ');
                    Console.WriteLine($"[{result}]");
                
           

        }
    }
}
