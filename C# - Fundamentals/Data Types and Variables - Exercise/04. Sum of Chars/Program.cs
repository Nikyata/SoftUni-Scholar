int num = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; i < num; i++)
{
    char letters = char.Parse(Console.ReadLine());
    sum += letters;
}
Console.WriteLine($"The sum equals: {sum}");
