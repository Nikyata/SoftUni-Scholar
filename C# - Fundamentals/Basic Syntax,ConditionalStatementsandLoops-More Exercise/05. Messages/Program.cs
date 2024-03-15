using static System.Runtime.InteropServices.JavaScript.JSType;
int clicks = int.Parse(Console.ReadLine());
string message = string.Empty;

for (int i = 0; i < clicks; i++)
{
    string digits = Console.ReadLine();
    int digitLength = digits.Length;
    int digit = digits[0] - '0';
    int offSet = (digit - 2) * 3;
    if(digit == 8 || digit == 9)
    {
        offSet += 1;
    }
    if(digit == 0)
    {
        message += (char)(digit + 32);
        continue;
    }
    int letterIndex = offSet + digitLength - 1;
    message += (char)(letterIndex + 97);
}
Console.WriteLine(message);
