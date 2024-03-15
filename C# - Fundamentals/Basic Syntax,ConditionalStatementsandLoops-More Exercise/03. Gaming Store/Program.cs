double currentBalance = double.Parse(Console.ReadLine());
string command = string.Empty;
double price = 0;
double totalSpend = 0;
while(command != "Game Time")
{
    command = Console.ReadLine();
    if(command == "OutFall 4")
    {
        price = 39.99;
        if(currentBalance >= price)
        {
            currentBalance -= price;
            Console.WriteLine($"Bought {command}");
            totalSpend += price;
        }
        else if (currentBalance == 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Too Expensive");
            continue;
        }

    }
    else if(command == "CS: OG")
    {
        price = 15.99;
        if (currentBalance >= price)
        {
            currentBalance -= price;
            Console.WriteLine($"Bought {command}");
            totalSpend += price;
        }
        else if (currentBalance == 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Too Expensive");
            continue;
        }
    }
    else if (command == "Zplinter Zell")
    {
        price = 19.99;
        if (currentBalance >= price)
        {
            currentBalance -= price;
            Console.WriteLine($"Bought {command}");
            totalSpend += price;
        }
        else if (currentBalance == 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Too Expensive");
            continue;
        }
    }
    else if (command == "Honored 2")
    {
        price = 59.99;
        if (currentBalance >= price)
        {
            currentBalance -= price;
            Console.WriteLine($"Bought {command}");
            totalSpend += price;
        }
        else if (currentBalance == 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Too Expensive");
            continue;
        }
    }
    else if (command == "RoverWatch")
    {
        price = 29.99;
        if (currentBalance >= price)
        {
            currentBalance -= price;
            Console.WriteLine($"Bought {command}");
            totalSpend += price;
        }
        else if (currentBalance == 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Too Expensive");
            continue;
        }
    }
    else if (command == "RoverWatch Origins Edition")
    {
        price = 39.99;
        if (currentBalance >= price)
        {
            currentBalance -= price;
            Console.WriteLine($"Bought {command}");
            totalSpend += price;
        }
        else if (currentBalance == 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Too Expensive");
            continue;
        }
    }
    else if(command == "Game Time")
    {
        break;
    }
    else
    {
        Console.WriteLine("Not Found");
        continue;
    }

}
if(currentBalance == 0)
{
    Console.WriteLine("Out of money!");
}
else
{
Console.WriteLine($"Total spent: ${totalSpend:f2}. Remaining: ${currentBalance:f2}");
}