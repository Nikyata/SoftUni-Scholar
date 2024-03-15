int startNum = int.Parse(Console.ReadLine());
int endNum = int.Parse(Console.ReadLine());
double sum = 0;
for (int i = startNum; i <= endNum; i++)
{
    int currentNum = i;
    Console.Write(i + " ");
    sum += currentNum;
}
Console.WriteLine();
Console.WriteLine($"Sum: {sum}");