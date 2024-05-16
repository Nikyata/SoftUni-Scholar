int n = int.Parse(Console.ReadLine());
double currentKegVolume = double.MinValue;
string biggestKeg = string.Empty;
for (int i = 0; i < n; i++)
{
//First – model – string
string kegModel = Console.ReadLine();
//Second –radius – floating-point number
double kegRadius = double.Parse(Console.ReadLine());
//Third – height – integer number
int kegHeight = int.Parse(Console.ReadLine());
    double kegVolume = Math.PI * Math.Pow(kegRadius, 2) * kegHeight;
    if(kegVolume > currentKegVolume)
    {
        currentKegVolume = kegVolume;
        biggestKeg = kegModel;
    }
}
Console.WriteLine(biggestKeg);