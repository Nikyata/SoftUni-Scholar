using System.Diagnostics;

namespace _04._Raw_Data
{

    class Car
    {
        public Car(string carModel, Engine carEngine, Cargo carCargo)
        {
            CarModel = carModel;
            CarEngine = carEngine;
            CarCargo = carCargo;
        }

        public string CarModel { get; set; }
        public new Engine CarEngine {get; set; }

        public new Cargo CarCargo { get; set; }
        internal class Engine
        {
            public Engine(int speed, int power)
            {
                Speed = speed;
                Power = power;
            }

            public int Speed { get; set; }
            public int Power { get; set; }
        }

        internal class Cargo
        {
            public Cargo(int cargoWeight, string cargoType)
            {
                CargoWeight = cargoWeight;
                CargoType = cargoType;
            }

            public int CargoWeight { get; set; } 
            public string CargoType { get; set; }
        }
    }
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split().ToArray();
                string model = inputs[0];
                int engineSpeed = int.Parse(inputs[1]);
                int enginePower = int.Parse(inputs[2]);
                int cargoWeight = int.Parse(inputs[3]);
                string cargoType = inputs[4];
                Car car = new Car(model, new Car.Engine(engineSpeed, enginePower),
                    new Car.Cargo(cargoWeight, cargoType));
                cars.Add(car);
            }

            string type = Console.ReadLine();
            if (type == "fragile")
            {

                var result = cars.Where(c => c.CarCargo.CargoWeight < 1000).ToList();
                foreach (var car in result)
                {
                    Console.WriteLine(car.CarModel);
                }

            }
            else if (type == "flamable")
            {
                var result = cars.Where(c => c.CarEngine.Power>250).ToList();
                foreach (var car in result)
                {
                    Console.WriteLine(car.CarModel);
                }
            }

           
        }
    }
}
