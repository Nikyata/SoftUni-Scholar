using System.Xml.XPath;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if(type == "int")
            {             
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                int result = GetMax(firstNum, secondNum);
                Console.WriteLine(result);
            }
           else if(type == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                char result = (char)GetMax(firstChar, secondChar);
                Console.WriteLine(result);
            }
            else
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                string result = GetMax(firstString, secondString);
                Console.WriteLine(result);
            }

            
        }
        static int GetMax(int value1, int value2)
        {
            if(value1 > value2)
            {
                return value1;
            }
            else
            {
                return value2;  
            }
        }
        static int GetMax(char value1, char value2)
        {
            if (value1 > value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }
        static string GetMax(string value1, string value2)
        {
            
            string result = "";
           
            int biggerString = value1.CompareTo(value2);
            if(biggerString > 0)
            {
                result = value1;
            }
            else
            {
                result = value2;
            }
            return result;
        }
    }
}
