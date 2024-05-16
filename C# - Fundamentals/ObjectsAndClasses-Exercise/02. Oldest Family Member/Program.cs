using System;

namespace _02._Oldest_Family_Member
{
    public class Person
    {
        public Person()
        {
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }
    }

    public class Family
    {
        public Family()
        {
            this.OrderPersons = new List<Person>();
        }

        public List<Person> OrderPersons { get; set; }

        public void AddMember(Person member)
        {
            OrderPersons.Add(member);
        }

        public Person GetOldest()
        {
            var oldestPerson = OrderPersons.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldestPerson;
        }


        internal class Program
        {
            static void Main(string[] args)
            {

                int n = int.Parse(Console.ReadLine());
                var newFamily = new Family();
                for (int i = 0; i < n; i++)
                {
                    string[] input = Console.ReadLine().Split();
                    Person person = new Person(input[0], int.Parse(input[1]));
                    newFamily.AddMember(person);
                }

                var result = newFamily.GetOldest();
                Console.WriteLine($"{result.Name} {result.Age}");
            }
        }
    }
}
