//On the first line, you will receive the key.
byte key = byte.Parse(Console.ReadLine());
//On the second line, you will receive n – the number of lines, which will follow.
byte n = byte.Parse(Console.ReadLine());
//On the next n lines, you will receive lower and uppercase characters from the Latin alphabet.
string message = "";
for (int i = 0; i < n; i++)
{
    char characters = char.Parse(Console.ReadLine());
    char keyToChar = (char)key;
    message += (char)(characters + keyToChar);
}
Console.WriteLine(message);