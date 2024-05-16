namespace _07.ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            HashSet<string> carList = new HashSet<string>();
            while((input = Console.ReadLine()) != "END")
            {
                string[] arguments = input.Split(", ").ToArray();
                string command = arguments[0];
                string carNumber = arguments[1];

                if(command == "IN")
                {
                    carList.Add(carNumber);
                }
                
                if(command == "OUT")
                {
                    carList.Remove(carNumber);
                }
            }
            if(carList.Count > 0)
            {
                foreach (var car in carList)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
           
        }
    }
}
