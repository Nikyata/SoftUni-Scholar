namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            VoewlsCount(input);
        }

        private static void VoewlsCount(string input)
        {
            int vowelsCounter = 0;
            char[] inputArr = input.ToLower().ToCharArray();

            for (int i = 0; i < inputArr.Length; i++)
            {
                
                if (inputArr[i] == 'a' || inputArr[i] == 'e' || inputArr[i] == 'o' || inputArr[i] == 'i' || inputArr[i] == 'u')
                {
                    vowelsCounter++;
                }
            }

            Console.WriteLine(vowelsCounter);
        }
    }
}
