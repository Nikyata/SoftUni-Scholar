namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            ValidatePassword(password);
        }

        private static void ValidatePassword(string password)
        {
            bool isLengthValid = false;
            if (password.Length >= 6 && password.Length <= 10)
            {
                isLengthValid = true;

            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!IsAllLettersOrDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!DigitsValidate(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isLengthValid == true && IsAllLettersOrDigits(password) && DigitsValidate(password))
            {
                Console.WriteLine("Password is valid");
            }
          
        }

        private static bool DigitsValidate(string password)
        {
            int digitsCounter = 0;
            foreach (char c in password)
            {
                if (Char.IsDigit(c))
                    digitsCounter++;
            }
            if(digitsCounter < 2)
            {
                return false;
            }
            return true;
        }

        public static bool IsAllLettersOrDigits(string pass)
        {
            foreach (char c in pass)
            {
                if (!Char.IsLetterOrDigit(c))
                    return false;
            }
            return true;
        }

    }
}
