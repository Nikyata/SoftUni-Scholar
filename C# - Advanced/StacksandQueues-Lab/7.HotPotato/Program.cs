namespace _7.HotPotato
{
    internal class Program
    {
        static void Main()
        {
            Queue<string> kids = new Queue<string>(Console.ReadLine().Split());
            int n = int.Parse(Console.ReadLine());
            int move = 1;
            while (kids.Count > 1)
            {
               string kidWithPotato = kids.Dequeue();
               if (move == n)
               {
                   Console.WriteLine($"Removed {kidWithPotato}");
                   move = 0;
               }
               else
               {
                   kids.Enqueue(kidWithPotato);
               }

                   move++;
            }

            Console.WriteLine($"Last is {kids.Dequeue()}");
        }
    }
}
