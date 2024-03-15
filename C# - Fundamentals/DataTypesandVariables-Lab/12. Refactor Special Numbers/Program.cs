int n = int.Parse(Console.ReadLine());
bool isSpecial = false;
int num = 0;
//
int sum = 0;
for (int i = 1; i <= n; i++)
{
    num = i;
    while (num > 0)
    {
        sum += (num % 10);
        num /= 10;
    }
    if (sum == 5 || sum == 7 || sum == 11)
    {
        isSpecial = true;
    }
    else
        isSpecial = false;
    sum = 0;
    Console.WriteLine($"{i} -> {isSpecial}");
}