//student name
string name = Console.ReadLine();
//age
int age = int.Parse(Console.ReadLine());
//average grade
double grade =  double.Parse(Console.ReadLine());
Console.Write($"Name: {name}, Age: {age}, Grade: {grade:f2}");