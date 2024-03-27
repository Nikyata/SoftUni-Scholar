string num = Console.ReadLine();
string[] array = num.Split(" ");
for (int i = 0; i < array.Length; i++)
{
    double currentNum = double.Parse(array[i]);
    Console.WriteLine($"{currentNum} => {(int)Math.Round(currentNum, MidpointRounding.AwayFromZero)}");
}