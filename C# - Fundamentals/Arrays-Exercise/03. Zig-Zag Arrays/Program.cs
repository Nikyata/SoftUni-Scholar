int lines = int.Parse(Console.ReadLine());
string[] firstArr = new string[lines];
string[] secondArr = new string[lines];
for (int i = 0; i < lines; i++)
{
    string[] input = Console.ReadLine().Split();
    if (i % 2 == 0)
    {
        firstArr[i] = input[0];
        secondArr[i] = input[1];
    }
    else
    {
        firstArr[i] = input[1];
        secondArr[i] = input[0];
    }
}
Console.WriteLine(string.Join(" ", firstArr));
Console.WriteLine(string.Join(" ", secondArr));