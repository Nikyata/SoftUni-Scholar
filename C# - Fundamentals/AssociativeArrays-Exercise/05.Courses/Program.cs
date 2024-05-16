namespace _05._Courses
{
    internal class Program
    {
        static void Main()
        {
            string input = "";
            var coursesList = new Dictionary<string, List<string>>();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] args = input.Split(" : ").ToArray();
                string courseName = args[0];
                string studentName = args[1];

                if (coursesList.ContainsKey(courseName))
                {
                    coursesList[courseName].Add(studentName);
                }
                else
                {
                    coursesList.Add(courseName, new List<string>(){studentName});
                }
            }

            foreach (var course in coursesList)
            {
                var students = course.Value;
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in students)
                {
                Console.WriteLine($"-- {student}");
                }
            }

        }
    }
}
