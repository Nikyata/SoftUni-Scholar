string[] array = Console.ReadLine().Split();
string bestString = "";
int bestCount = 0;
for (int i = array.Length - 1; i >= 0 ; i--)
{

    int count = 1;
	for (int j = i - 1; j >= 0; j--)
	{
        if (array[j] == array[i])
        {
            count++;
            if(bestCount <= count)
            {
                bestCount = count;
                bestString = array[i];
            }
        }
        else
        {
            break;
        }
    }
}
for (int i = 0; i < bestCount; i++)
{
    Console.Write(bestString + " ");
}
