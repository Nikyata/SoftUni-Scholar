namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] arguments = Console.ReadLine().Split();
            int magicNum = int.Parse(arguments[0]);
            int power = int.Parse(arguments[1]);
            
            
                while(sequence.Contains(magicNum))
                {
                    int index = sequence.IndexOf(magicNum);
                    int leftIndex = Math.Max(0, index - power);
                    int rightIndex = Math.Min(sequence.Count - 1, index + power);
                    int range = rightIndex - leftIndex + 1;
                    sequence.RemoveRange(leftIndex, range);
                }
                int sum = sequence.Sum();

                Console.WriteLine(sum);
        }

            
        }
    }

