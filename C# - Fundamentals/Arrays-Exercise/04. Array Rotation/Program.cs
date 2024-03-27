string[] inputArr = Console.ReadLine().Split();
int rotations = int.Parse(Console.ReadLine());
for (int i = 0; i < rotations; i++)
{
    string firstDigit = inputArr[0];
	for (int j = 0; j < inputArr.Length - 1; j++)
	{
		inputArr[j] = inputArr[j + 1];
	}
	inputArr[^1] = firstDigit;
}
Console.WriteLine(string.Join(" ", inputArr));