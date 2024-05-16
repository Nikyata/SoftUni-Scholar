using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;

namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine()
                .Split()
                .ToList();
            List<string> mergedList = new List<string>();
            string input = "";
            string concat = "";
            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] arguments = input.Split();
                string command = arguments[0];
                switch (command)
                {
                    case "merge":
                        
                        mergeItems(arguments, inputList, mergedList, concat);

                        break;
                    case "divide":
                        int index = int.Parse(arguments[1]);
                        int partitions = int.Parse(arguments[2]);
                        string currentWord = inputList[index];
                        for (int i = 0; i < currentWord.Length / partitions; i++)
                        {
                            Console.Write(currentWord[i]);
                            
                        }
                        Console.Write(" ");
                        for (int i = currentWord.Length / partitions; i < currentWord.Length; i++)
                        {
                            Console.Write(currentWord[i]);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", inputList));
        }
        
        private static void mergeItems(string[] arguments, List<string> inputList, List<string> mergedList, string concat)
        {
            int startIndex = int.Parse(arguments[1]);
            int endIndex = int.Parse(arguments[2]);
            int minIndex = Math.Max(0, startIndex);
            int maxIndex = Math.Min(inputList.Count -1, endIndex);
                        
            if (minIndex == maxIndex || minIndex > maxIndex)
            {
                return;
            }
            for (int i = minIndex; i <= maxIndex; i++)
            {
                         
                mergedList.Add(inputList[i]);
                concat = string.Join("", mergedList.ToArray());
                            
             
            }
            mergedList.Clear();
            inputList.RemoveRange(minIndex, maxIndex - minIndex);
            inputList[startIndex] = concat;
        }
    }
}
