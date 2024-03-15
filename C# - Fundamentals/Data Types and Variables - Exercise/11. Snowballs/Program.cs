//You will receive N – an integer, the number of snowballs being made by Tony and Andi.
using System.Numerics;

byte n = byte.Parse(Console.ReadLine());
ushort snowballSnow = 0;
ushort biggestSnowballSnow = ushort.MinValue;
ushort snowballTime = 0;
ushort biggestSnowballTime = ushort.MinValue;
BigInteger snowballValue = 0;
BigInteger snowballWithBiggestValue = 0;
byte snowballQuality = 0;
byte biggestSnowballQuality = byte.MinValue;
int i = 0;
int j = 0;
for (i = 0; i < n; i++)
{
//For each snowball you will receive 3 input lines:
//•	On the first line, you will get the snowballSnow – an integer.
 snowballSnow = ushort.Parse(Console.ReadLine());
//•	On the second line you will get the snowballTime – an integer.
 snowballTime = ushort.Parse(Console.ReadLine());
    //•	On the third line, you will get the snowballQuality – an integer.
 snowballQuality = byte.Parse(Console.ReadLine());
	for (j = 0; j < n; j++)
	{
//For each snowball you must calculate its snowballValue by the following formula:

		snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
		if(snowballValue > snowballWithBiggestValue)
		{
		snowballWithBiggestValue = snowballValue;
			biggestSnowballSnow = snowballSnow;
			biggestSnowballTime = snowballTime;
			biggestSnowballQuality = snowballQuality;
        }
    }
}
//In the end, you must print the highest calculated snowballValue.
Console.WriteLine($"{biggestSnowballSnow} : {biggestSnowballTime} = {snowballWithBiggestValue} ({biggestSnowballQuality})");