using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace _04.StarEnigma
{
    
    internal class Program
    {
        class Message
        {
            public Message(string name, int population, string type, int soldiers)
            {
                Name = name;
                Population = population;
                Type = type;
                Soldiers = soldiers;
            }

            public string Name { get; set; }
            public int Population { get; set; }

            public string Type { get; set; }

            public int Soldiers { get; set; }

        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Message> messages = new List<Message>();
            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();
                string decryptedMessage = "";
                string starPattern = @"[SsTtAaRr]";
                int decryptKey = 0;

                foreach (Match m in Regex.Matches(encryptedMessage, starPattern))
                {
                    decryptKey += m.Length;
                }
               
                    var message = encryptedMessage.ToCharArray();
                    for (int k = 0; k < message.Length; k++)
                    {
                        decryptedMessage += (char)(message[k] - decryptKey);
                    }

                    string pattern = @"\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*\:(?<population>\d+)[^\@\-\!\:\>]*\!(?<type>A|D)\![^\@\-\!\:\>]*\-\>[^\@\-\!\:\>]*?(?<soldiers>\d+)[^\@\-\!\:\>]*";

                    var match = Regex.Match(decryptedMessage, pattern);
                    if (match.Success) 
                    {
                        string name = match.Groups["planet"].Value;
                        int population = int.Parse(match.Groups["population"].Value);
                        string type = match.Groups["type"].Value;
                        int soldiers = int.Parse(match.Groups["soldiers"].Value);
                        Message newMessage = new Message(name, population, type, soldiers);
                        messages.Add(newMessage);
                    }
            }

            List<Message> attackedPlanets = messages.Where(m=> m.Type == "A").ToList();
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(x=>x.Name))
            {
                Console.WriteLine($"-> {planet.Name}");
            }

            List<Message> destroyedPlanets = messages.Where(m => m.Type == "D").ToList();
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets.OrderBy(x => x.Name))
            {
                Console.WriteLine($"-> {planet.Name}");
            }

        }
    }
}
