using System.Linq;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandCount = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();
            for (int i = 0; i < commandCount; i++)
            {
                string[] guests = Console.ReadLine().Split().ToArray();
                string name = guests[0];

                if (guests[2] == "going!")
                {
                    if (guestList.Contains(name))
                    {
                    Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(name);
                    }
                }
                else if (guests[2] == "not")
                {
                    if (guestList.Contains(name))
                    {
                        guestList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }




            }
            Console.WriteLine(string.Join("\n", guestList));
        }
    }
}