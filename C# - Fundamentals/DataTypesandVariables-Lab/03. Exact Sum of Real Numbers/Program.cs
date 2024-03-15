int numCount = int.Parse(Console.ReadLine());
decimal sum = 0;
for (int i = 0; i < numCount; i++)
{
    decimal num = decimal.Parse(Console.ReadLine());
    sum += num;

}
Console.WriteLine(sum);