//Input
double budgetForFilm = double.Parse(Console.ReadLine());    
int extras =  int.Parse(Console.ReadLine());
double priceOfOneExtra  = double.Parse(Console.ReadLine());

//Calculations
double priceForDecor = budgetForFilm  * 0.1;
double priceForClothes = extras * priceOfOneExtra;
if (extras >=150)
{
    priceForClothes *= 0.9;
}

double priceForAll = priceForDecor + priceForClothes;


//Output
if (priceForAll <= budgetForFilm)
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {budgetForFilm - priceForAll:f2} leva left.");
}
else
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {priceForAll - budgetForFilm:f2} leva more.");
}


