using System.Text.RegularExpressions;

namespace _01.Furniture
{

    class Furniture
    {
        public Furniture(string name, double price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public double Total => Price * Count;

    }
    internal class Program
    {
        static void Main()
        {
            string input = "";
            string pattern = @">>(?<product>[A-Za-z]+)<<(?<price>\d+\.\d+|\d+)!(?<count>\d+)";
            double totalPrice = 0;
            List<Furniture> furnitures = new List<Furniture>();
            while ((input = Console.ReadLine()) != "Purchase")
            {
                
                foreach (Match m in Regex.Matches(input, pattern))
                {
                    string name = m.Groups["product"].Value;
                    double price = double.Parse(m.Groups["price"].Value);
                    int count = int.Parse(m.Groups["count"].Value);
                    Furniture newFurniture = new Furniture(name, price, count);
                    furnitures.Add(newFurniture);
                    
                }
            }

            Console.WriteLine($"Bought furniture:");
            foreach (var product in furnitures)
            {
                Console.WriteLine($"{product.Name}");
                totalPrice += product.Total;
            }

            Console.WriteLine($"Total money spend: {totalPrice:F2}");
        }
    }
}
