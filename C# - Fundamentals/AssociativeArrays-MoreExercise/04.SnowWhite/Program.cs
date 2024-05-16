using System.Collections.Immutable;
using System.Net.WebSockets;
using System.Xml.Linq;

namespace _04.Snowwhite
{
    internal class Program
    {

        static void Main()
        {
            string line = "";
            Dictionary<string, Dictionary<string, ulong>> dwarves = new Dictionary<string, Dictionary<string, ulong>>();
            //List<Dwarf> allDwarfs = new List<Dwarf>();
            while ((line = Console.ReadLine()) != "Once upon a time")
            {
                string[] args = line.Split(" <:> ");
                string dwarfName = args[0];
                string dwarfHat = args[1];
                ulong physics = ulong.Parse(args[2]);

                if (!dwarves.ContainsKey(dwarfHat))
                {
                    dwarves.Add(dwarfHat, new Dictionary<string, ulong>());
                    dwarves[dwarfHat].Add(dwarfName, physics);
                }
                else if (dwarves[dwarfHat].ContainsKey(dwarfName))
                {
                    if (dwarves[dwarfHat][dwarfName] < physics)
                    {
                        dwarves[dwarfHat][dwarfName] = physics;
                    }
                }
                else
                {
                    dwarves[dwarfHat].Add(dwarfName, physics);
                }
            }
            var sortedDwarfs = new Dictionary<string, ulong>();

            foreach (var kvp in dwarves.OrderByDescending(x => x.Value.Count()))
            {
                string hatColor = kvp.Key;
                var nameAndPhysics = kvp.Value;

                foreach (var kvpOne in nameAndPhysics)
                {
                    string name = kvpOne.Key;
                    ulong physics = kvpOne.Value;
                    sortedDwarfs.Add($"({hatColor}) {name} <-> ", physics);
                }
            }
            foreach (var kvp in sortedDwarfs.OrderByDescending(x => x.Value))
            {
                string name = kvp.Key;
                ulong physycs = kvp.Value;

                Console.WriteLine($"{name}{physycs}");
            }
        }
    }
}