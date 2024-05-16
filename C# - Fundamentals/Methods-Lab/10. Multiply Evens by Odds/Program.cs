using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }

        private static int GetMultipleOfEvenAndOdds(int number)
        {
            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            int result = evenSum * oddSum;
            return result;
        }

        private static int GetSumOfEvenDigits(int number)
        {
            int sumOfEven = 0;
            number = Math.Abs(number);
            int numberCopy = number;
            while(number > 0)
            {
                numberCopy = number % 10;
                if(numberCopy % 2 == 0)
                {
                    sumOfEven += numberCopy;
                }
                number /= 10;
            }

            return sumOfEven;


        }
        private static int GetSumOfOddDigits(int number)
        {
            int sumOfOdds = 0;
            number = Math.Abs(number);
            int numberCopy = number;
            while (number > 0)
            {
                numberCopy = number % 10;
                if (numberCopy % 2 == 1)
                {
                    sumOfOdds += numberCopy;
                }
                number /= 10;
            }

            return sumOfOdds;
        }
    }
}
