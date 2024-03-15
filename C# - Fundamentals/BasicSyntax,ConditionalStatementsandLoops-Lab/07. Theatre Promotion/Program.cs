string dayType = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
double ticketPrice = 0;
switch (dayType)
{
	case "Weekday":
			if (age >= 0 && age <= 18)
			{
			ticketPrice = 12;

            }
			else if (age > 18 && age <= 64)
			{
			     ticketPrice = 18;
			}
			else if(age > 64 && age <= 122)
			{
			ticketPrice = 12;
			}
            else
            {
                Console.WriteLine("Error!");
            }
				break;
	case "Weekend":
        if (age >= 0 && age <= 18)
        {
            ticketPrice = 15;

        }
        else if (age > 18 && age <= 64)
        {
            ticketPrice = 20;
        }
        else if (age > 64 && age <= 122)
        {
            ticketPrice = 15;
        }
        else
        {
            Console.WriteLine("Error!");
        }
        break;

    case "Holiday":
        if (age >= 0 && age <= 18)
        {
            ticketPrice = 5;

        }
        else if (age > 18 && age <= 64)
        {
            ticketPrice = 12;
        }
        else if (age > 64 && age <= 122)
        {
            ticketPrice = 10;
        }
        else
        {
            Console.WriteLine("Error!");
        }
        break;
}
if(ticketPrice != 0)
{
    Console.WriteLine($"{ticketPrice}$");
}
