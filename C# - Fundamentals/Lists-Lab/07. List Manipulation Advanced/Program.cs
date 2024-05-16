using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            string input = "";
            int previousCount = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split();
                string command = arguments[0];
                

                switch (command)
                {
                    case "Contains":
                        string number = arguments[1];
                        if (numbers.Contains(int.Parse(number)))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }

                        break;
                    case "PrintEven":
                        List<int> printEven = numbers
                            .Where(x => x % 2 == 0)
                            .ToList();
                        Console.WriteLine(string.Join(" ", printEven));
                        break;

                    case "PrintOdd":
                        List<int> printOdd = numbers
                            .Where(x => x % 2 != 0)
                            .ToList();
                        Console.WriteLine(string.Join(" ", printOdd));
                        break;
                    case "GetSum":
                        int sum = numbers.Sum();
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string condition = arguments[1];
                        int numberFilter = int.Parse(arguments[2]);
                        if (condition == "<")
                        {
                            List<int> printLowerNums = numbers
                                .Where(x => x < numberFilter)
                                .ToList();
                            Console.WriteLine(string.Join(" ", printLowerNums));
                        }
                        else if (condition == ">")
                        {
                            List<int> printBiggerNums = numbers
                                .Where(x => x > numberFilter)
                                .ToList();
                            Console.WriteLine(string.Join(" ", printBiggerNums));
                        }
                        else if (condition == "<=")
                        {
                            List<int> printLowEqNums = numbers
                                .Where(x => x <= numberFilter)
                                .ToList();
                            Console.WriteLine(string.Join(" ", printLowEqNums));
                        }
                        else if (condition == ">=")
                        {
                            List<int> printBigEqNums = numbers
                                .Where(x => x >= numberFilter)
                                .ToList();
                            Console.WriteLine(string.Join(" ", printBigEqNums));
                        }

                        break;
                    case "Add":
                        previousCount++;
                        number = arguments[1];
                        numbers.Add(int.Parse(number));
                        break;
                    case "Remove":
                        previousCount++;
                        number = arguments[1];
                        numbers.Remove(int.Parse(number));
                        break;
                    case "RemoveAt":
                        previousCount++;
                        number = arguments[1];
                        numbers.RemoveAt(int.Parse(number));
                        break;
                    case "Insert":
                        previousCount++;
                        number = arguments[1];
                        string index = arguments[2];
                        numbers.Insert(int.Parse(index), int.Parse(number));
                        break;

                }
            }

            if (previousCount!= 0)
            {
            Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}