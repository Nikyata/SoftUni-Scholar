using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp3
{
    internal class Program
    {
        // immutable    
        // reference type --> acts like a value type
        // always assign result after string operations !
        // Concat --> concatenate 1+ strings into single value -->  string.Concat("ABC","CBA") --> ABCCBA;
        // Reverse --> revrse string --> End --> dnE
        // IndexOf(optional start from index) --> checks if value exists and if so return staring index. "Anastasia".IndexOf("n") --> 1 search left --> right
        // LastIndexOf(optional --> starts from zero )  serach right --> left 
        // Contains --> check if substring is presented --> returns true/false;
        // Substring --> extract sub string from the roiginal string 
        // Remove() --> oposite of substring
        // Replace() --> repalce all mathicng occurances
        // ToUpper() --> convert all chars to upper

        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            string line = string.Empty;
            while ((line = Console.ReadLine()) != "end of contests")
            {
                var tokens = line.Split(":");
                string name = tokens[0];
                string password = tokens[1];
                contests[name] = password;
                //"{contest}:{password for contest}
            }

            line = string.Empty;
            Dictionary<string, Dictionary<string, int>> candidates = new Dictionary<string, Dictionary<string, int>>();

            while ((line = Console.ReadLine()) != "end of submissions")
            {
                var tokens = line.Split("=>");
                string name = tokens[0];
                string password = tokens[1];
                string userName = tokens[2];
                int points = int.Parse(tokens[3]);
                if (contests.ContainsKey(name) && contests[name] == password)
                {

                    if (!candidates.ContainsKey(userName))
                    {
                        candidates[userName] = new Dictionary<string, int>();
                        candidates[userName].Add(name, points);
                    }
                    else
                    {
                        // Save the user with the contest they take part in (a user can take part in many contests) and the points the user has in the given contest. If you receive the same contest and the same user, update the points, only if the new ones are more than the older ones
                        if (candidates[userName].ContainsKey(name))
                        {
                            var existingPoints = candidates[userName][name];
                            if (points >= existingPoints)
                            {
                                candidates[userName][name] = points;
                            }
                        }
                        else
                        {
                            candidates[userName].Add(name, points);
                        }
                    }
                }
            }

            // In the end, you have to print the info for the user with the most points in the format 
            var bestStudent = candidates
             .Select(x => new
             {
                 Name = x.Key,
                 Sum = x.Value.Values.Sum()
             })
             .OrderByDescending(x => x.Sum)
             .FirstOrDefault();

            Console.WriteLine($"Best candidate is {bestStudent.Name} with total {bestStudent.Sum} points.");

            //After that print all students ordered by their names. For each user print each contest with the points in descending order. See the examples
            Console.WriteLine("Ranking:");
            foreach (var student in candidates.OrderBy(x => x.Key))
            {
                Console.WriteLine(student.Key);

                foreach (var kvp in student.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}
/*
Part One Interview:success
Js Fundamentals:Jsfundmpass
C# Fundamentals:fundPass
Algorithms:fun
end of contests
C# Fundamentals=>fundPass=>Tanya=>350
Algorithms=>fun=>Tanya=>380
Part One Interview=>success=>Nikola=>120
Java Basics Exam=>jsfundmpass=>Mary=>400
Part One Interview=>success=>Tanya=>220
OOP Advanced=>password123=>Jim=>231
C# Fundamentals=>fundPass=>Tanya=>250
C# Fundamentals=>fundPass=>Nikola=>200
Js Fundamentals=>Jsfundmpass=>Tanya=>400
end of submissions
 */
