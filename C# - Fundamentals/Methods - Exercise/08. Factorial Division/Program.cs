namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long firstNum = long.Parse(Console.ReadLine());
            long secondNum = long.Parse(Console.ReadLine());
            double result = FactorialDivided(CalculateFactorial(firstNum), CalculateFactorial(secondNum));
            Console.WriteLine($"{result:f2}");
        }
        static double CalculateFactorial(long num)
        {
            double factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        static double FactorialDivided(double firstFactorial, double secondFactorial)
        {
            double result = firstFactorial / secondFactorial;
            return result;
        }
    }
}
