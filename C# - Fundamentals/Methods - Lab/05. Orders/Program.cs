
using System.Diagnostics;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            printPriceInDouble(product,quantity);
        }

        private static void printPriceInDouble(string product,int quantity)
        {
            double price = 0;
            switch (product)
            {
                case "coffee":
                    price = 1.5;
                    break;
                case "water":
                    price = 1.0;
                    break;
                case "coke":
                    price = 1.4;
                    break;
                case "snacks":
                    price = 2.0;
                    break;
            }
            Console.WriteLine($"{price * quantity:f2}");
        }
    }
}
