namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            PrintSmallestNum(firstNum, secondNum, thirdNum);
        }

        private static void PrintSmallestNum(int firstNum, int secondNum, int thirdNum)
        {
            if (firstNum < secondNum && firstNum < thirdNum)
            {
                Console.WriteLine(firstNum);
            }
            else if (secondNum < firstNum && secondNum < thirdNum)
            {
                Console.WriteLine(secondNum);
            }
            else
            {
                Console.WriteLine(thirdNum);
            }
        }
    }
}
