
namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            switch (operation)
            {
                case "add":
                    addMethod(num1, num2);
                    break;
                case "substract":
                    substractMethod(num1, num2);
                    break;
                case "multiply":
                    multiplyMethod(num1, num2);
                    break;
                case "divide":
                    divideMethod(num1, num2);
                    break;

            }

        }

        private static void addMethod(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        private static void substractMethod(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }
        private static void multiplyMethod(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }
        private static void divideMethod(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }
    }
}
