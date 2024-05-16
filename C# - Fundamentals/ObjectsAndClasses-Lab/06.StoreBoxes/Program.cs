using System.Diagnostics;

namespace _06._Store_Boxes
{
    internal class Program
    {
        static void Main()
        {
            List<Box> boxes = new List<Box>();
            string line = "";
            while ((line = Console.ReadLine()) != "end")
            {
                string[] args = line.Split();

                string serialNum = args[0];
                string itemName = args[1];
                int itemQuantity = int.Parse(args[2]);
                decimal price = decimal.Parse(args[3]);
                Item item = new Item(itemName, price)
                {
                    Name = itemName,
                    Price = price
                };
                Box box = new Box(serialNum, item, itemQuantity)
                {
                    ItemQuantity = itemQuantity,
                    SerialNumber = serialNum,
                    Item = item

                };

                boxes.Add(box);
            }

            boxes =  boxes.OrderByDescending(x => x.BoxPrice).ToList();
            foreach (var box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:f2}");
            }
        }
    }

     class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

     class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal BoxPrice => ItemQuantity * Item.Price;
    }
}
