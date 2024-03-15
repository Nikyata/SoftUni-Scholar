// ((daysInMonth * capsulesCount) * pricePerCapsule)
double pricePerCapsule = 0;
int daysInMonth = 0;
int capsulesCount = 0;
//On the first line, you will receive integer N – the count of orders the shop will receive.
int ordersCount = int.Parse(Console.ReadLine());
double totalOrdersPrice = 0;
for (int i = 1; i <= ordersCount; i++)
{
    //or each order you will receive the following information:
    //=> Price per capsule – floating-point number in the range [0.00…1000.00].
    pricePerCapsule = double.Parse(Console.ReadLine());
    //=> Days – integer in the range [1…31].
    daysInMonth = int.Parse(Console.ReadLine());
    //=> Capsules count – integer in the range [0…2000].
    capsulesCount = int.Parse(Console.ReadLine());
    double orderPrice = ((daysInMonth * capsulesCount) * pricePerCapsule);
    Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
    totalOrdersPrice += orderPrice;
}
Console.WriteLine($"Total: ${totalOrdersPrice:f2}");
