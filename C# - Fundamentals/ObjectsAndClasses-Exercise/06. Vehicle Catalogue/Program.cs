namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main()
        {
            string input ="";
            List<Vehicle> vehiclesCatalog = new List<Vehicle>();
            while ((input = Console.ReadLine()) != "End")
            {
                string[] args = input.Split();
                Vehicle newVehicle = new Vehicle(args[0], args[1], args[2], int.Parse(args[3]));
                vehiclesCatalog.Add(new Vehicle(args[0], args[1], args[2], int.Parse(args[3])));
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                string vehicleModel = input;
                Vehicle foundVehicle = vehiclesCatalog.FirstOrDefault(v => v.Model == vehicleModel);
                if (foundVehicle != null)
                {
                    Console.WriteLine(foundVehicle);
                }
            }

            double averageHp = vehiclesCatalog
                .Where(v => v.Type == "Car")
                .Select(vehicle => vehicle.Hp)
                .DefaultIfEmpty()
                .Average();
            Console.WriteLine($"Cars have average horsepower of: {averageHp:f2}.");

            averageHp = vehiclesCatalog
                .Where(v => v.Type == "Truck")
                .Select(vehicle => vehicle.Hp)
                .DefaultIfEmpty()
                .Average();
            Console.WriteLine($"Trucks have average horsepower of: {averageHp:f2}.");

        }
    }

    class Vehicle
    {
        public Vehicle(string type, string model, string color, int hp)
        {
            if (type == "car")
            {
                type = "Car";
            }
            else if( type == "truck")
            {
                type = "Truck";
            }

            Type = type;
            Model = model;
            Color = color;
            Hp = hp;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Hp { get; set; }
        public override string ToString()
        {
            return $"Type: {Type}\n" +
                   $"Model: {Model}\n"+
                   $"Color: {Color}\n"+
                   $"Horsepower: {Hp}";
        }
    }
}
