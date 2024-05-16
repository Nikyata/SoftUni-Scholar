using System;
using System.Text;

namespace _03._Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
1 2 1 3
ikegfp'jpne)bv=41P83X@
ujfufKt)Tkmyft'duEprsfjqbvfv=53V55XA
find
            */

            int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = "";
            StringBuilder sb = new StringBuilder();
            List<string> message = new List<string>();
            while ((input = Console.ReadLine()) != "find")
            {

                int counter = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    char currentSymbol = (char)(input[i] - key[counter]);
                    sb.Append(currentSymbol);
                    counter++;
                    if(counter > key.Length - 1)
                    {
                        counter = 0;
                    }

                }
            message.Add(sb.ToString());
            sb.Clear();
            }
            string material = "";
            string coordinates = "";
            foreach (var element in message)
            {
                int materialStartIndex = element.IndexOf('&');
                int materialEndIndex = element.LastIndexOf('&');
                material = element.Substring(materialStartIndex + 1, materialEndIndex - materialStartIndex - 1);

                int coordinatesStartIndex = element.IndexOf('<');
                int coordinatesEndIndex = element.LastIndexOf('>');
                coordinates = element.Substring(coordinatesStartIndex + 1, coordinatesEndIndex - coordinatesStartIndex - 1);

                Console.WriteLine($"Found {material} at {coordinates}");
            }

        }
    }
}

