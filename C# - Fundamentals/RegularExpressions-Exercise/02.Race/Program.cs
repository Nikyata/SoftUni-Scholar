using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    internal class Program
    {
        static void Main()
        {
            string[] participants = Console.ReadLine().Split(", ").ToArray();
            Dictionary<string, int> allParticipants = new Dictionary<string, int>();
            string input = "";
            while ((input = Console.ReadLine()) != "end of race")
            {
                string namePattern = @"[A-Za-z]";
                string distancePattern = @"\d";
                int distance = 0;
                StringBuilder participant = new StringBuilder();
                foreach (Match m in Regex.Matches(input, namePattern))
                {
                    participant.Append(m.Value);
                }

                foreach (Match m in Regex.Matches(input, distancePattern))
                {
                    distance += int.Parse(m.Value);
                }

                if (participants.Contains(participant.ToString()))
                {
                    if (!allParticipants.ContainsKey(participant.ToString()))
                    {
                        allParticipants.Add(participant.ToString(), distance);
                    }
                    else
                    {
                        allParticipants[participant.ToString()] += distance;
                    }
                }
            }
            var winner = allParticipants.OrderByDescending(x => x.Value).Select(x => x.Key).Take(3).ToList();
            
                Console.WriteLine($"1st place: {winner[0]}");
                Console.WriteLine($"2nd place: {winner[1]}");
                Console.WriteLine($"3rd place: {winner[2]}");
            
        }
    }
}
