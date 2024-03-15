int input = int.Parse(Console.ReadLine());

int number = input;
int factorialSum = 0;
while (number > 0)
{
    int digit = number % 10;
    number /= 10;

    int factorial = 1;
    for (int i = 1; i <= digit; i++)
    {
        factorial *= i;
    }
        factorialSum += factorial;

}

if(factorialSum == input)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}