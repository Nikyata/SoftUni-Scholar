using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    class Order
    {
        public string Customer { get; set; }
        public string Product { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

        public double orderTotal => Count * Price;

        public override string ToString()
        {
            return $"{Customer}: {Product} - {orderTotal:f2}";
        }
    }
    internal class Program
    {
        static void Main()
        {
            List<Order> orders = new List<Order>();
              string pattern = @"\%(?<name>[A-Z][a-z]+)\%[^|$%.]*\<(?<product>\w+)\>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+(?:\.\d+)?)\$";
            //string pattern = @"\%(?<name>[A-Z][a-z]+)\%[^|$%.]*\<(?<product>\w+)\>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\";
            string input = "";
            double totalIncome = 0;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                foreach (Match match in Regex.Matches(input, pattern))
                {
                    Order newOrder = new Order();
                    newOrder.Customer = match.Groups["name"].Value;
                    newOrder.Product = match.Groups["product"].Value;
                    newOrder.Count = int.Parse(match.Groups["count"].Value);
                    newOrder.Price = double.Parse(match.Groups["price"].Value);
                    orders.Add(newOrder);
                }
            }

            foreach (var order in orders)
            {
                Console.WriteLine(order);
                totalIncome += order.orderTotal;
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
