//Input
int chickenMenu = int.Parse(Console.ReadLine());
int fishMenu = int.Parse(Console.ReadLine());
int vegetarianMenu = int.Parse(Console.ReadLine());

//Calculations

double priceOfChickenMenu = chickenMenu * 10.35;
double priceOfFishMenu = fishMenu * 12.4;
double priceOfVegetarianMenu = vegetarianMenu * 8.15;
double priceOfMenu = priceOfChickenMenu + priceOfFishMenu + priceOfVegetarianMenu;
double priceOfDessert = priceOfMenu * 0.2;
double finalPrice = priceOfMenu + priceOfDessert + 2.5;
//Output

Console.WriteLine(finalPrice);