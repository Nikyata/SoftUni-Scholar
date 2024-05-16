int num = int.Parse(Console.ReadLine());
int numCopy = num;
int sum = 0;
while (numCopy > 0)
{
    int digit = numCopy % 10;
    sum += digit;
    numCopy /= 10;
}
Console.WriteLine(sum);