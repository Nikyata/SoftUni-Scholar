namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> firstList = Console.ReadLine().Split().ToList();
            List<string> secondList = Console.ReadLine().Split().ToList();
            List<string> result = new List<string>();
            
            int longerList = Math.Max(firstList.Count, secondList.Count);
            for (int i = 0; i < longerList; i++)
            {
                if(i < firstList.Count)
                {
                    result.Add(firstList[i]);
                }
                if(i < secondList.Count)
                {
                result.Add(secondList[i]);

                }
            }
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
