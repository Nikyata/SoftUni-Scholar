int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    char firstLetter = (char)('a' + i);
    for (int j = 0; j < n; j++)
    {
        char secondLetter = (char)('a' + j);
        for (int m = 0; m < n; m++)
        {
            char thirdLetter = (char)('a' + m);
    Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
        }
    }
}
