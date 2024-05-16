int n = int.Parse(Console.ReadLine());
int leftBrackedCount = 0;
int rightBrackedCount = 0;
for (int i = 1; i <= n; i++)
{
    string character = Console.ReadLine();

    if(character == "(")
    {
        leftBrackedCount++;
    }
        
    else if (character == ")")
    {
        rightBrackedCount++;
        if(leftBrackedCount - rightBrackedCount != 0)
        {
            Console.WriteLine("UNBALANCED");
            return;
        }
    }
}
if(leftBrackedCount - rightBrackedCount == 0)
{
    Console.WriteLine("BALANCED");
}
else
{
    Console.WriteLine("UNBALANCED");
}