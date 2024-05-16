namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            string digits = "";
            string letters = "";
            string others = "";
            for (int i = 0; i < line.Length; i++)
            {
                char currentChar = line[i];
                if(char.IsDigit(currentChar))
                {
                    digits += currentChar;
                }
                else if(char.IsLetter(currentChar))
                {
                    letters += currentChar;
                }
                else
                {
                    others += currentChar;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);

        }
    }
}
