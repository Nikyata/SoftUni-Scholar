namespace _04.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            SortedDictionary<string, Dictionary<string, double>> shopInfo = new SortedDictionary<string, Dictionary<string, double>>();
            while((input = Console.ReadLine()) != "Revision") 
            {
                string[] arguments = input.Split(", ").ToArray();
                string shopName = arguments[0];
                string product = arguments[1];
                double price = double.Parse(arguments[2]);
                if(shopInfo.ContainsKey(shopName))
                {
                    shopInfo[shopName].Add(product, price);
                }
                else
                {
                    shopInfo.Add(shopName, new Dictionary<string, double>());
                    shopInfo[shopName].Add(product, price);
                }
            }
            foreach (var shop in shopInfo)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
