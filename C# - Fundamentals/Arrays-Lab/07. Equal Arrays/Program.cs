using System;

int[] firstArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] secondArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < firstArr.Length; i++)
{
    if (firstArr[i] != secondArr[i])
    {
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        return;
    }
}

int sum = 0;
foreach (int currentNum in firstArr)
{
    sum += currentNum;
}

Console.WriteLine($"Arrays are identical. Sum: {sum}");