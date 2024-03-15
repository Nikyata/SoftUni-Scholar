int startingYield = int.Parse(Console.ReadLine());
int daysCount =  0;
int consumables = 26;
int yieldedSpice = 0;
if (startingYield >= 100)
{
    while (startingYield >= 100)
    {
        if (startingYield < 100)
        {
            yieldedSpice -= consumables;
            break;
        }
        daysCount++;
        yieldedSpice += startingYield;
        yieldedSpice -= consumables;
        startingYield -= 10;
    }
yieldedSpice -= consumables;
Console.WriteLine(daysCount);
Console.WriteLine(yieldedSpice);
}
else 
{
    Console.WriteLine(daysCount);
    Console.WriteLine(yieldedSpice);
}