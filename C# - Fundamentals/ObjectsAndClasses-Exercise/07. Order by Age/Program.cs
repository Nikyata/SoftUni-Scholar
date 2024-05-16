namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main()
        {
            string input = "";
            List<Person> People = new List<Person>();
            while ((input = Console.ReadLine()) != "End")
            {
                string[] args = input.Split();
                Person newPerson = new Person(args[0], args[1], int.Parse(args[2]));
                var personFound = People.FirstOrDefault(p => p.id == args[1]);
                if (personFound != null)
                {
                    personFound.age = newPerson.age;
                    personFound.name = newPerson.name;
                }
                else
                {
                    People.Add(newPerson);
                }
            }

            var orderedList = People.OrderBy(person => person.age).ToList();
            foreach (Person person in orderedList)
            {
                Console.WriteLine(person);
            }
        }
    }

    class Person
    {
        public Person(string name, string id, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }

        public string name { get; set; }
        public string id { get; set; }
        public int age { get; set; }

        public override string ToString()
        {
            return $"{name} with ID: {id} is {age} years old.";
        }
    }
}
