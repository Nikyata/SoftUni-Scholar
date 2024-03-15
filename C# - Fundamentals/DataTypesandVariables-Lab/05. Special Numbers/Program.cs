int input = int.Parse(Console.ReadLine());

int number = input;
int numSum = 0;
while (number > 0)
{
    numSum += number % 10;
    number /= 10;
    for (int i = 1; i <= input; i++)
    {
        if (numSum % 5 == 0 || numSum % 7 == 0 || numSum % 11 == 0)
        {
            Console.WriteLine($"{i} -> True");
        }
        else
        {
            Console.WriteLine($"{i} -> False");
        }
    }
}
