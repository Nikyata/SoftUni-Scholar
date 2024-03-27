using System.Collections.Specialized;
using System.Net;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = "";
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split();
                switch (arguments[0])
                {
                    case "Add":
                        int number = int.Parse(arguments[1]);
                        list.Add(number);
                        break;
                    case "Insert":
                        number = int.Parse(arguments[1]);
                        int index = int.Parse(arguments[2]);
                        if(index < 0 || index > list.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        list.Insert(index, number);
                        break;
                    case "Remove":

                        index = int.Parse(arguments[1]);
                        if (index < 0 || index > list.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        list.RemoveAt(index);
                        break;
                    case "Shift":
                        string direction = arguments[1];
                        int count = int.Parse(arguments[2]);
                        count %= list.Count;
                        if(direction == "left")
                        {
                            List<int> shiftedPart = list.GetRange(0, count);
                            list.RemoveRange(0, count);
                            list.InsertRange(list.Count, shiftedPart);
                        }
                        else if(direction == "right")
                        {
                            List<int> shiftedPart = list.GetRange(list.Count - count, count);
                            list.RemoveRange(list.Count - count, count);
                            list.InsertRange(0, shiftedPart);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
