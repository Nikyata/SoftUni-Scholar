using System.Xml.Linq;

namespace _02.Judge
{
    internal class Program
    {
        static void Main()
        {
            string input = "";
            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> students = new Dictionary<string, int>();
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] args = input.Split(" -> ");
                string userName = args[0];
                string contestName = args[1];
                int points = int.Parse(args[2]);

                if (!contests.ContainsKey(contestName))
                {
                    contests.Add(contestName, new Dictionary<string, int>());
                    contests[contestName][userName] = points;
                }
                else
                {
                    if (!contests[contestName].ContainsKey(userName))
                    {
                        contests[contestName][userName] = points;

                    }
                    else
                    {
                        if (contests[contestName][userName] < points)
                        {
                            contests[contestName][userName] = points;

                        }
                    }
                }
            }

            foreach (var kvpContest in contests)
            {
                Console.WriteLine($"{kvpContest.Key}: {kvpContest.Value.Count} participants");
                int count = 0;
                foreach (var kvpStudent in kvpContest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    count++;
                    Console.WriteLine($"{count}. {kvpStudent.Key} <::> {kvpStudent.Value}");
                }
                count = 0;
            }

            Console.WriteLine("Individual standings:");

            foreach (var kvpContest in contests)
            {
                foreach (var student in kvpContest.Value)
                {
                    if (!students.ContainsKey(student.Key))
                    {
                        students.Add(student.Key, student.Value);
                    }
                    else
                    {
                        students[student.Key] = students[student.Key] + student.Value;
                    }
                }
            }
            int counter1 = 0;
            foreach (var name in students.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                counter1++;
                Console.WriteLine($"{counter1}. {name.Key} -> {name.Value}");
            }
        }
    }

}

