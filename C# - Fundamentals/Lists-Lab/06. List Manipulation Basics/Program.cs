namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = "";
            while((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split();
                string command = arguments[0];
                string number = arguments[1];
                
                switch (command)
                {
                    case "Add":
                        numbers.Add(int.Parse(number));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(number));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(number));
                        break;
                    case "Insert":
                        string index = arguments[2];
                        numbers.Insert(int.Parse(index), int.Parse(number));
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
