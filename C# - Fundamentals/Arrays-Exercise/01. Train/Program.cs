int n = int.Parse(Console.ReadLine());
int[] arr  = new int[n];
int sum = 0;
for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    arr[i] = num;
    sum += arr[i];
}

Console.WriteLine(string.Join(" ", arr));
Console.WriteLine(sum);