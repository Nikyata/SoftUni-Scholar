decimal a = decimal.Parse(Console.ReadLine());
decimal b = decimal.Parse(Console.ReadLine());
bool areEqual = false;
decimal comparison;
decimal eps = 0.000001M;
if(a > b)
{
    comparison = a - b;
    if(comparison < eps)
    {
        areEqual = true;
    }
}
else if(a < b)
{
    comparison = b- a;
    if (comparison < eps)
    {
        areEqual = true;
    }
}
Console.WriteLine(areEqual);