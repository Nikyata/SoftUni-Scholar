namespace _03._Orders
{
    internal class Program
    {
        static void Main()
        {
            string input = "";
            var results = new Dictionary<string, List<double>>();
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] args = input.Split().ToArray();
                string product = args[0];
                double price = double.Parse(args[1]);
                double count = double.Parse(args[2]);


                if (!results.ContainsKey(product))
                {
                    results.Add(product, new List<double>(){price, count});
                }
                else 
                {
                    results[product][0] = price;
                    results[product][1] += count;
                    
                }
            }

            foreach (var product in results)
            {
                Console.WriteLine($"{product.Key} -> {product.Value[0] * product.Value[1]:f2}");
            }
        }
    }
}
