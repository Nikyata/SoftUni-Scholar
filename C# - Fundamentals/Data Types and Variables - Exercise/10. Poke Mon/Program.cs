//On the first line, you will receive N – an integer.
int n = int.Parse(Console.ReadLine());
//On the second line, you will receive M – an integer.
int m = int.Parse(Console.ReadLine());
//On the third line, you will receive Y – an integer
byte y = byte.Parse(Console.ReadLine());
float percent = n * 0.5f;
int pokedTarget = 0;
    while(n >= m)
{
    pokedTarget++;
    n -= m;
    if (n == percent)
    {
        if(y != 0)
        n /= y;
    }
}
Console.WriteLine(n);
Console.WriteLine(pokedTarget);