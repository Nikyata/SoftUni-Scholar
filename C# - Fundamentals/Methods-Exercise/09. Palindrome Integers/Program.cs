using System.Linq;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while ((input = Console.ReadLine()) != "END")
            {
                CheckIfItsPalindromeOrNot(input);
            }
        }

        private static void CheckIfItsPalindromeOrNot(string input)
        {
           
            bool isPalindrome = false;
            char[] reversedString = input.ToCharArray();
            Array.Reverse(reversedString);
            string reverse = new string(reversedString);
            if(input == reverse)
            {
                isPalindrome = true;
            }
            Console.WriteLine(isPalindrome);
        }
    }
}
