namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            for (int i = 0; i < input.Length; i++)
            {
                if (isValidUser(input[i]))
                {
                    Console.WriteLine(input[i]);
                }
            }
        }

        static bool isValidUser(string username)
        {
            if (username.Length < 3 || username.Length > 16)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < username.Length; i++)
                {
                    if (!char.IsDigit(username[i]) && !char.IsLetter(username[i]) && username[i] != '-' &&
                        username[i] != '_')
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }

}
