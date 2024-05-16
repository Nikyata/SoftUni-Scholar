namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main()
        {
            List<string> phraseList = new List<string>()
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can't live without this product."
            };
            List<string> eventList = new List<string>()
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            List<string> authorsList = new List<string>()
                {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
            Random rndPhrase = new Random();


            List<string> cityList = new List<string>()
                { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int rndNum = rndPhrase.Next(phraseList.Count);

                string phrase = phraseList[rndNum];
                string rndEvent = eventList[rndNum];
                string author = authorsList[rndNum];
                string city = cityList[rndNum];
                Console.WriteLine($"{phrase} {rndEvent} {author} – {city}.");
            }




        }


    }

}