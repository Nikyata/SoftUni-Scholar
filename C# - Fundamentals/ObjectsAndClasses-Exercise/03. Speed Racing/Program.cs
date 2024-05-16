using System.Collections.Specialized;
using System.Reflection;

namespace _03._Speed_Racing
{
    class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumption = fuelConsumption;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumption { get; set; }

        public double TravelledDistance = 0;

        public void Drive(double amountOfKm)
        {
            var consumption = amountOfKm * this.FuelConsumption;
            if (this.FuelAmount - consumption < 0)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.FuelAmount -= (consumption);
                this.TravelledDistance += amountOfKm;
            }
        }
    }
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Car>carList = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                Car NewCar = new Car(input[0], double.Parse(input[1]), double.Parse(input[2]));
                carList.Add(NewCar);
            }

            string command = "";
            while ((command = Console.ReadLine()) != "End")
            {
                string[] args = command.Split().ToArray();
                string token = args[0];
                string selectedCar = args[1];
                double run = double.Parse(args[2]);

                carList.Where(c => c.Model == selectedCar).ToList().ForEach(c => c.Drive(run));
            }

            foreach (Car car in carList)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
            
        }
    }
}
