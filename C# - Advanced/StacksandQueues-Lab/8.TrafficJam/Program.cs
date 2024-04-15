namespace _8.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int passedCars = 0;
            string input = "";
            while ((input = Console.ReadLine()) != "end")
            {
                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                   
                        for (int i = 0; i < n; i++)
                        {
                            if (cars.Count > 0)
                            {
                                Console.WriteLine($"{cars.Dequeue()} passed!");
                                passedCars++;
                            }
                        }
                    
                }
            }

            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}
