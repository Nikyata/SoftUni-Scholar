namespace _07._Company_Users
{
    internal class Program
    {
        static void Main()
        {
            string input = "";
            var companyList = new Dictionary<string, List<string>>();
            while ((input = Console.ReadLine()) != "End")
            {
                string[] args = input.Split(" -> ");
                string name = args[0];
                string id = args[1];

                if (!companyList.ContainsKey(name))
                {
                    companyList.Add(name, new List<string>(){id});
                }
                else
                {
                    if (!companyList[name].Contains(id))
                    companyList[name].Add(id);
                }
            }

            foreach (var company in companyList)
            {
                var employees = company.Value;
                Console.WriteLine(company.Key);
                foreach (var employee in employees)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }

        }
    }
}
