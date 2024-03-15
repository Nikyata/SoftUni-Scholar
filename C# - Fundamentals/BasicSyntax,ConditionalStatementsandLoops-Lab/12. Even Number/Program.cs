int n = int.Parse(Console.ReadLine());
while (n % 2 != 0)
{
    Console.WriteLine("Please write an even number.");
    n = int.Parse(Console.ReadLine());
    if (n % 2 == 0) break;
}
Console.WriteLine($"The number is: {Math.Abs(n)}");