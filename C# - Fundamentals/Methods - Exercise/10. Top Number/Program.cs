using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (ValidateOddDigits(i) && ValidateIfDivisible(i))
                {
                    Console.WriteLine(i);
                }
            }


        }

        static bool ValidateOddDigits(int num)
        {
            while (num > 0)
            {
                if ((num % 10) % 2 == 1)
                    return true;
                num /= 10;
            }

            return false;
        }
        static bool ValidateIfDivisible(int n)
        {
            int digitSum = 0;
            while (n > 0)
            {
                digitSum += n % 10;
                n /= 10;
            }

            if(digitSum % 8 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
