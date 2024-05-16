using Console = System.Console;

namespace Objects_and_Classes___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            List<Student> students = new List<Student>();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] line = input.Split();

                string firstName = line[0];
                string lastName = line[1];
                string age = line[2];
                string homeTown = line[3];

                Student student = IsStudentExist(students, firstName, lastName);
                if(student == null)
                {
                    students.Add(new Student
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = homeTown
                    });
                }
                else
                {
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
            
            }
            string city = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.HomeTown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }


        }

        private static Student IsStudentExist(List<Student> students, string firstName, string lastName)
        {
            Student result = null;
            foreach (Student student in students)
            {
                if(student.FirstName == firstName && student.LastName == lastName)
                {
                    result = student;
                }
            }
            return result;
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeTown { get; set; }
        public string Age { get; set; }

    }
}