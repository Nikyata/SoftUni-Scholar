namespace _08.SoftUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            HashSet<string> regularGuests = new HashSet<string>();
            HashSet<string> vipGuests = new HashSet<string>();
            while(true)
            {
                input = Console.ReadLine();
                if(input == "END")
                {
                    break;
                }
                if(input == "PARTY")
                {
                    while((input = Console.ReadLine()) != "END")
                    {
                        if(input == "END")
                        {
                            break;
                        }
                        if(regularGuests.Contains(input))
                        {
                            regularGuests.Remove(input);
                        }

                        if (vipGuests.Contains(input))
                        {
                            vipGuests.Remove(input);
                        }
                    }
                    break;
                }

                if (char.IsDigit(input[0]))
                {
                    vipGuests.Add(input);
                }
                else
                {
                    regularGuests.Add(input);
                }
            }

            int count = regularGuests.Count + vipGuests.Count;
            Console.WriteLine(count);
            foreach (var vip in vipGuests)
            {
                Console.WriteLine(vip);
            }
            foreach (var regulars in regularGuests)
            {
                Console.WriteLine(regulars);
            }
        }
    }
}
