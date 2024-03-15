//  A count of people who are going on vacation.
using System.Threading.Tasks.Dataflow;

int peopleCount = int.Parse(Console.ReadLine());
// Type of the group (Students, Business or Regular).
string groupType = Console.ReadLine();
// The day of the week which the group will stay on (Friday, Saturday or Sunday).
string day =  Console.ReadLine();
double price = 0;
double total = 0;
switch (day)
{
	case "Friday":
		if(groupType == "Students")
		{
			price = 8.45;
		}
		else if(groupType == "Business")
		{
			price = 10.90;
		}
		else
		{
			price = 15;
		}
		break;
	case "Saturday":
        if (groupType == "Students")
        {
            price = 9.80;
        }
        else if (groupType == "Business")
        {
            price = 15.60;
        }
        else
        {
            price = 20;
        }
        break;
	case "Sunday":
        if (groupType == "Students")
        {
            price = 10.46;
        }
        else if (groupType == "Business")
        {
            price = 16;
        }
        else
        {
            price = 22.50;
        }
        break;

}
if(peopleCount >= 30 && groupType == "Students")//or Students – if the group is 30 or more people, you should reduce the total price by 15%.
{
    total = peopleCount * price;
    total = total * 0.85;
}
else if(peopleCount >= 100 && groupType == "Business")//or Business – if the group is 100 or more people, 10 of the people stay for free.
{
    peopleCount -= 10;
    total = peopleCount * price;
}
else if(peopleCount >= 10 && peopleCount <= 20 && groupType == "Regular")//or Regular – if the group is between 10 and 20 people (both inclusively), reduce the total price by 5%.
{
    total = peopleCount * price;
    total = total * 0.95;
}
else
{
    total = peopleCount * price;
}

Console.WriteLine($"Total price: {total:f2}");