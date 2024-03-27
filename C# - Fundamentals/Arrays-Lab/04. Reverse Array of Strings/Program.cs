string[] array = Console.ReadLine().Split(" ");
for (int i = 0; i < array.Length / 2; i++)
{
    string firstElement = array[i];
    string lastElement = array[array.Length - 1 - i];

    array[i] = lastElement;
    array[array.Length - 1 - i] = firstElement;
}

Console.WriteLine(string.Join(" ", array));