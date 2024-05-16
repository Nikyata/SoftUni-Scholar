namespace _02.AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);
                if (students.ContainsKey(name))
                {
                    students[name].Add(grade);
                }
                else
                {
                    students.Add(name, new List<decimal>());
                    students[name].Add(grade);
                }
            }
            foreach (var student in students)
            {
                var grades = string.Join(" ", student.Value.Select(x => x.ToString("F2")));
                Console.WriteLine($"{student.Key} -> {grades} (avg: {student.Value.Average():f2})");
            }
        }
    }
}
