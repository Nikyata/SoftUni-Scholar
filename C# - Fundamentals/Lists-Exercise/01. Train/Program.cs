namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagonsState = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int capacity = int.Parse(Console.ReadLine());
            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();
                if (arguments[0] == "Add")
                {
                    wagonsState.Add(int.Parse(arguments[1]));
                }
                else
                {
                    for (int i = 0; i < wagonsState.Count; i++)
                    {
                        if ((wagonsState[i] + int.Parse(arguments[0]))  <= capacity)
                        {
                            wagonsState[i] += int.Parse(arguments[0]);
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagonsState));
        }
    }
}
