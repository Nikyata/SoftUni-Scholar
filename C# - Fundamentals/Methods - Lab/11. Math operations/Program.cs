namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());
            double result = CalculateMethod(firstNumber, operation, secondNumber);
            Console.WriteLine(result);
        }

        private static double CalculateMethod(int firstNumber, string operation,int secondNumber)
        {
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / (double)secondNumber;
                    break;

            }
            return result;
        }
    }
}
