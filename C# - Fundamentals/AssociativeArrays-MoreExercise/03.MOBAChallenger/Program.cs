using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
 
namespace _3._MOBA_Challenger
{ class Program
    {
        static void Main()
        {

            string line = "";
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();
            while ((line = Console.ReadLine()) != "Season end")
            {
                if (line.Contains(" -> "))
                {
                    string[] parts = line.Split(" -> ");
                    string name = parts[0];
                    string position = parts[1];
                    int skills = int.Parse(parts[2]);
                    if (!players.ContainsKey(name))
                    {
                        players.Add(name, new Dictionary<string, int>());
                        players[name].Add(position, skills);
                    }
                    else
                    {
                        if (players[name].ContainsKey(position))
                        {
                            int currentSkill = players[name][position];
                            if (currentSkill < skills)
                            {
                                players[name][position] = skills;
                            }
                        }
                        else
                        {
                            players[name].Add(position, skills);
                        }
                    }
                }
                else if (line.Contains(" vs "))
                {
                    string[] playerDuel = line.Split(" vs ");
                    string playerOne = playerDuel[0];
                    string playerTwo = playerDuel[1];
                    if (players.ContainsKey(playerOne) && players.ContainsKey(playerTwo))
                    {
                        string playerToRemove = "";
                        foreach (var pos in players[playerOne])
                        {
                            foreach (var poss in players[playerTwo])
                            {
                                if (pos.Key == poss.Key)
                                {
                                    if (players[playerOne].Values.Sum() > players[playerTwo].Values.Sum())
                                    {
                                        playerToRemove = playerTwo;
                                    }
                                    else if (players[playerOne].Values.Sum() < players[playerTwo].Values.Sum())
                                    {
                                        playerToRemove = playerOne;
                                    }
                                }
                            }
                        }

                        players.Remove(playerToRemove);

                    }
                }
            }
            //print the players, ordered by total skill in descending order, then ordered by player name in ascending order. 
            foreach (var player in players.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                foreach (var kvp in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {kvp.Key} <::> {kvp.Value}");
                }
            }
        }
    }
}
/*
Peter -> Adc -> 400
Bush -> Tank -> 150
Faker -> Mid -> 200
Faker -> Support -> 250
Faker -> Tank -> 250
Faker vs Bush
 */