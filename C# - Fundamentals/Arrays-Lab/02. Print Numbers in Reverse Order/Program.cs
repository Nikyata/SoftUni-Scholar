int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    array[i] = number;
}
for (int j = array.Length-1; j >= 0; j--)
{
    Console.Write($"{array[j]} ");
}   