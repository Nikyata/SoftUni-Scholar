namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int result = SubstractThirdFromResult(SumFirstTwoNums(firstNum, secondNum), thirdNum);
            Console.WriteLine(result);
        }

        static int SumFirstTwoNums(int num1, int num2)
        {
            int SumResult = num1 + num2;
            return SumResult;
        }
        static int SubstractThirdFromResult(int SumResult, int num3)
        {
            int result = SumResult - num3;
            return result;
        }
    }
}
