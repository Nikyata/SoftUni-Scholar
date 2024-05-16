using system;
namespace _04._Students;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public class Student(string firstName, string lastName, double grade)
{
    FirstName = firstName;

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }
}