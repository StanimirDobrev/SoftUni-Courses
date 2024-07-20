// Input
double tripCost = double.Parse(Console.ReadLine());
int puzzleCount = int.Parse(Console.ReadLine());
int dollsCount= int.Parse(Console.ReadLine());
int bearsCount = int.Parse(Console.ReadLine());
int minionsCount = int.Parse(Console.ReadLine());
int trucksCount= int.Parse(Console.ReadLine());
//Calculations
double toysPrice = (puzzleCount * 2.6) + (dollsCount * 3) + (bearsCount * 4.1) + (minionsCount * 8.2) + (trucksCount * 2);
int toysCount = puzzleCount + dollsCount + bearsCount + minionsCount + trucksCount;
if (toysCount >= 50)
{
    toysPrice *= 0.75;
}
toysPrice *= 0.9;

//Output
if (toysPrice >= tripCost)
{
    Console.WriteLine($"Yes! {toysPrice - tripCost:f2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {tripCost - toysPrice:f2} lv needed.");
}