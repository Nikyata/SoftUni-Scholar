int n = int.Parse(Console.ReadLine());
int sum = 0;
int num = 1;
for (int i = 1; i <= n ; i++)
{
    int currentNum = i * 2 - 1;
    Console.WriteLine(currentNum);
    sum += currentNum;
}
Console.WriteLine($"Sum: {sum}");