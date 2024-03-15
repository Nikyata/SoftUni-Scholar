double myMoney = 0;
double coins = 0;
string command = string.Empty;
double price = 0;
while(command != "Start")
{
    command = Console.ReadLine();
    if (command == "Start") break;
    coins = double.Parse(command);
    if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
    {
        myMoney += coins;
    }
    else
    {
        Console.WriteLine($"Cannot accept {coins}");
    }
}
string order = string.Empty;
while(order != "End")
{
    order = Console.ReadLine();
    if (order == "End") break;
    if(order == "Nuts")
    {
        price = 2;
        if(price > myMoney)
        {
            Console.WriteLine("Sorry, not enough money");
            continue;
        }
        else
        {
            Console.WriteLine($"Purchased {order.ToLower()}");
            myMoney -= price;
        }
    }
    else if(order == "Water")
    {
        price = 0.7;
        if (price > myMoney)
        {
            Console.WriteLine("Sorry, not enough money");
            continue;
        }
        else
        {
            Console.WriteLine($"Purchased {order.ToLower()}");
            myMoney -= price;
        }
    }
    else if(order == "Crisps")
    {
        price = 1.5;
        if (price > myMoney)
        {
            Console.WriteLine("Sorry, not enough money");
            continue;
        }
        else
        {
            Console.WriteLine($"Purchased {order.ToLower()}");
            myMoney -= price;
        }
    }
    else if(order == "Soda")
    {
        price = 0.8;
        if (price > myMoney)
        {
            Console.WriteLine("Sorry, not enough money");
            continue;
        }
        else
        {
            Console.WriteLine($"Purchased {order.ToLower()}");
            myMoney -= price;
        }
    }
    else if(order == "Coke")
    {
        price = 1;
        if (price > myMoney)
        {
            Console.WriteLine("Sorry, not enough money");
            continue;
        }
        else
        {
            Console.WriteLine($"Purchased {order.ToLower()}");
            myMoney -= price;
        }
    }
    else
    {
        Console.WriteLine("Invalid product");
    }
}
Console.WriteLine($"Change: {myMoney:f2}");