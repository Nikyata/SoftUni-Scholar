using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("-");
                string creator = input[0];
                string teamName = input[1];
                Team newTeam = new Team(creator, teamName);
                bool teamAlreadyExists = teams.Select(t => t.TeamName).Contains(teamName);
                bool creatorAlreadyIn = teams.Select(t => t.Creator).Contains(creator);
                if (teamAlreadyExists)
                {
                    Console.WriteLine($"Team {newTeam.TeamName} was already created!");
                }
                else if (creatorAlreadyIn)
                {
                    Console.WriteLine($"{newTeam.Creator} cannot create another team!");
                }
                else
                {
                    Console.WriteLine($"Team {newTeam.TeamName} has been created by {newTeam.Creator}!");
                    teams.Add(newTeam);
                }

            }

            string membersInput = "";
            while ((membersInput = Console.ReadLine()) != "end of assignment")
            {
                string[] args = membersInput.Split("->");
                string member = args[0];
                string teamToJoin = args[1];

                bool isTeamExisting = teams.Select(t => t.TeamName)
                    .Contains(teamToJoin);
                bool isAlreadyMember = teams.Any(x => x.Members.Contains(member));
                bool isCreatorCheating = teams.Any(x => x.Creator == member);

                if (isTeamExisting && isAlreadyMember == false && isCreatorCheating == false)
                {
                    int teamIndex = teams.FindIndex(t => t.TeamName == teamToJoin);
                    teams[teamIndex].Members.Add(member);
                }
                else if (isTeamExisting == false)
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                    continue;
                }
                else if (isAlreadyMember == true || isCreatorCheating == true)
                {
                    Console.WriteLine($"Member {member} cannot join team {teamToJoin}!");
                    continue;
                }
            }


            List<Team> orderedTeamWithMembers = teams
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName)
                .ToList();

            List<Team>emptyTeams = teams
                .Where(m => m.Members.Count <= 0)
                .OrderBy(x=>x.TeamName)
                .ToList();

            foreach (var team in orderedTeamWithMembers)
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.Creator}");
                team.Members.Sort();
                Console.WriteLine(string.Join(Environment.NewLine, team.Members.Select(x => "-- " + x)));

            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in emptyTeams)
            {
                
                Console.WriteLine(string.Join(Environment.NewLine, team.TeamName));
            }
        }
    }

    public class Team
    {
        public Team(string creator, string teamName)
        {
            Creator = creator;
            TeamName = teamName;
            Members = new List<string>();
        }

        public string Creator { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }

    }
}
