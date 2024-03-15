int n = int.Parse(Console.ReadLine());
int times = int.Parse(Console.ReadLine());
do
{
    int sum = n * times;
    Console.WriteLine($"{n} X {times} = {sum}");
    times++;
}
while (times <= 10);