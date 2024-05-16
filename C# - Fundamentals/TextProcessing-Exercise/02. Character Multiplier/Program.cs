namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Console.WriteLine(MultiplyStrings(input[0], input[1])); ;
            
        }

        static int MultiplyStrings(string s, string s1)
        {
            int longerString = Math.Max(s.Length, s1.Length);
            int result = 0;

            for (int i = 0; i < longerString; i++)
            {
                int multiplier1 = 1, multiplier2 = 1;
                if(i < s.Length) multiplier1 = s[i];
                if(i < s1.Length) multiplier2 = s1[i];

                result += multiplier1 * multiplier2;
            }
            return result;
        }
    }
}
