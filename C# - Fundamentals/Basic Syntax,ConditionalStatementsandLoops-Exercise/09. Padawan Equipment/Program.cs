//The amount of money John has – floating-point number in the range [0.00…1000.00].
using System.Threading.Channels;

double money = double.Parse(Console.ReadLine());
//The count of students – integer in the range [0…100].
int studentsCount = int.Parse(Console.ReadLine());
//The price of lightsabers for a single saber – floating-point number in the range [0.00…100.00].
double saberPrice = double.Parse(Console.ReadLine());
//The price of robes for a single robe – floating-point number in the range [0.00…100.00].
double robesPrice = double.Parse(Console.ReadLine());
//The price of belts for a single belt – floating-point number in the range [0.00…100.00].
double beltPrice = double.Parse(Console.ReadLine());

double sabersCount = studentsCount + (Math.Ceiling(studentsCount * 0.1));
double freeBelts = studentsCount / 6;

double totalExpences = (sabersCount * saberPrice) + (beltPrice * (studentsCount - freeBelts)) + (robesPrice * studentsCount);

Console.WriteLine(money >= totalExpences ? $"The money is enough - it would cost {totalExpences:f2}lv." : $"John will need {totalExpences - money:f2}lv more.");