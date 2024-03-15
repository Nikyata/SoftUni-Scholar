//On the first input line – lost games count – integer in the range [0…1000].
int lostGames = int.Parse(Console.ReadLine());
//On the second line – headset price – floating-point number in the range [0…1000].
double headsetPrice = double.Parse(Console.ReadLine());
int headsetCount = lostGames / 2;
//On the third line – mouse price – floating-point number in the range [0…1000].
double mousePrice = double.Parse(Console.ReadLine());
int mouseCount = lostGames /3;
//On the fourth line – keyboard price – floating-point number in the range [0…1000].
double keyboardPrice = double.Parse(Console.ReadLine());
int keyboardCount = 0;
//On the fifth line – display price – floating-point number in the range [0… 1000].
double displayPrice =  double.Parse(Console.ReadLine());
int displayCount = 0;

double rageExpences = 0;

    rageExpences += (headsetPrice * headsetCount);


    rageExpences += (mousePrice * mouseCount);

//When Petar trashes both his mouse and headset in the same lost game, he also trashes his keyboard.

    keyboardCount = lostGames / 6;
    rageExpences += (keyboardPrice * keyboardCount);

//Every second time, when he trashes his keyboard, he also trashes his display. 

    displayCount = keyboardCount /2;
    rageExpences += displayCount * displayPrice;

Console.WriteLine($"Rage expenses: {rageExpences:f2} lv.");