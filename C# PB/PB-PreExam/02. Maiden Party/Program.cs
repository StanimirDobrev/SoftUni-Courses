//Input

double priceForParty = double.Parse(Console.ReadLine());
int loveMessages = int.Parse(Console.ReadLine());
int roses = int.Parse(Console.ReadLine());
int keychain = int.Parse(Console.ReadLine());
int caricatures = int.Parse(Console.ReadLine());
int lucks =  int.Parse(Console.ReadLine());

//Calculations
int itemsCount = loveMessages + roses + keychain + caricatures + lucks;
double itemsSum = (loveMessages * 0.6) + (roses * 7.2) + (keychain * 3.60) + (caricatures * 18.20) + (lucks * 22);
if (itemsCount >= 25)
{
    itemsSum *= 0.65;
}
double hostingPrice = itemsSum * 0.1;
double totalSum = itemsSum - hostingPrice;


//Output
if (totalSum >= priceForParty)
{
    Console.WriteLine($"Yes! {totalSum - priceForParty:f2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {priceForParty - totalSum:f2} lv needed.");
}