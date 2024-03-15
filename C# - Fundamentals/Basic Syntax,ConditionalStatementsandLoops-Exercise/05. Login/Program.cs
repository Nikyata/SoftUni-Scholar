string username = Console.ReadLine();
string password = string.Empty;
string input = string.Empty;
for (int i = username.Length-1; i >= 0; i--)
{
    password += username[i];
}

int counter = 0;
while(input != password)
{
    input = Console.ReadLine();
    counter++;
    if (counter == 4 && input != password)
    {
        Console.WriteLine($"User {username} blocked!");
        break;
    }
    if (input == password)
    {
        Console.WriteLine($"User {username} logged in.");
        break;
    }
    else 
    {
        Console.WriteLine("Incorrect password. Try again.");
    }

}


