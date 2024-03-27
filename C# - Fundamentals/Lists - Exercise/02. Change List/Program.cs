namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = "";
            while((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();
                switch (arguments[0])
                {
                    case "Delete":
                        for (int i = 0; i < list.Count; i++)
                        {
                        list.Remove(int.Parse(arguments[1])); 
                        }
                        break;
                    case "Insert":
                        int index = int.Parse(arguments[2]);
                        int number = int.Parse(arguments[1]);
                        list.Insert(index, number);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
