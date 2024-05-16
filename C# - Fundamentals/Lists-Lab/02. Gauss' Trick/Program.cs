using System.Runtime.InteropServices;

namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int firstNum = numbers[i];
                int lastNum = numbers[numbers.Count - i - 1];
                result.Add(firstNum + lastNum);       
            }
            if(numbers.Count % 2 == 1)
            {
                result.Add(numbers[numbers.Count/ 2]);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
