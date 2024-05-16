using System.Collections.Generic;
using System.Threading.Channels;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var parkingList = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] args = Console.ReadLine().Split();
                string command = args[0];
                string name = args[1];
               
                switch (command)
                {
                    case "register":
                        string regNum = args[2];
                        if (!parkingList.ContainsKey(name))
                        {
                            parkingList.Add(name, regNum);
                            Console.WriteLine($"{name} registered {regNum} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {regNum}");
                        }
                        break;
                    case "unregister":
                        if (!parkingList.ContainsKey(name))
                        {
                            Console.WriteLine($"ERROR: user {name} not found");
                        }
                        else
                        {
                            parkingList.Remove(name);
                            Console.WriteLine($"{name} unregistered successfully");
                        }
                        break;
                }

               
            }
            foreach (var element in parkingList)
            {
                Console.WriteLine($"{element.Key} => {element.Value}");
            }
        }
    }
}
