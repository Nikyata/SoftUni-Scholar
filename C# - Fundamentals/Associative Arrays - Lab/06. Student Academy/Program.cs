namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           var studentsList =  new Dictionary<string, List<double>>();
            ;
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsList.ContainsKey(name))
                {
                    studentsList.Add(name, new List<double>(){grade});
                }
                else
                {
                    studentsList[name].Add(grade); 
                }

            }

                Console.WriteLine(string.Join($"{Environment.NewLine}", studentsList
                .Where(x => (x.Value.Sum() / x.Value.Count) >= 4.50)
                .Select(x => $"{x.Key} -> {x.Value.Sum() / x.Value.Count():f2}")));
        }
    }
}
