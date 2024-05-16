using System.Diagnostics;

namespace _04._Students
{
    class Students
    {
        public Students(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set;}
        public string LastName { get; set;}
        public double Grade { get; set;}

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> studentsList = new List<Students>();
            int studentsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < studentsCount; i++)
            {
                string[] studentString = Console.ReadLine().Split();

                Students student = new Students(studentString[0],
                    studentString[1],
                    double.Parse(studentString[2]));
                studentsList.Add(student);
            }
            List<Students> orderedListOfStudents = studentsList.OrderByDescending(s => s.Grade).ToList();
            foreach (var student in orderedListOfStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}
