using System.Diagnostics;

namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main()
        {
            List<Car> Cars = new List<Car>();
            List<Truck> Trucks  = new List<Truck>();
            string input = "";
            while((input = Console.ReadLine()) != "end")
            {
                string[] args = input.Split("/");
                string type = args[0];
                switch (type)
                {
                    case "Car":
                        Car car = new Car(args[1], args[2], args[3])
                        {
                            Brand = args[1],
                            Model = args[2],
                            HorsePower = args[3]
                        };
                        Cars.Add(car);
                        break;
                    case "Truck":
                        Truck truck = new Truck(args[1], args[2], args[3])
                        {
                            Brand = args[1],
                            Model = args[2],
                            Weight = args[3]
                        };
                        Trucks.Add(truck);
                        break;
                }

              
            }
     
            if(Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in Cars.OrderBy(car => car.Brand))
                {
                        Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in Trucks.OrderBy(truck => truck.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
 
        }
    }

    class Truck
    {
        public Truck(string brand, string model, string weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
        public string Brand { get; set;}
        public string Model { get; set;}
        public string Weight { get; set;}
    }
    class Car
    {
        public Car(string brand, string model, string horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }
    class VehicleCatalog
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}
