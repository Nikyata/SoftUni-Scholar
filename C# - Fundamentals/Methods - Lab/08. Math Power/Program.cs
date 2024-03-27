using System.Threading.Channels;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            
            double result = NumToPow(number, power);
            Console.WriteLine(result);
        }

        private static double NumToPow(double number, double power)
        {
            double result = 0d;
           result = Math.Pow(number, power);
            return result;
        }
    }
}
