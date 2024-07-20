//               Пролет(spring)     Лято(summer)       Есен(autumn)         Зима(winter)
//До 5 човека	50.00 лв. на човек	48.50 лв. на човек	60.00 лв. на човек	86.00 лв. на човек
//Над 5 човека	48.00 лв. на човек	45.00 лв. на човек	49.50 лв. на човек	85.00 лв. на човек

//Input
int people = int.Parse(Console.ReadLine());
string season =  Console.ReadLine();

//Calculations
double pricePerPerson = 0;
if (people <= 5)
{
    switch (season)
    {
        case ("spring"): pricePerPerson = 50; break;
        case ("summer"): pricePerPerson = 48.5; break;
        case ("autumn"): pricePerPerson = 60; break;
        case ("winter"): pricePerPerson = 86; break;
    }
}
else if (people > 5)
{
    switch (season)
    {
        case ("spring"): pricePerPerson = 48; break;
        case ("summer"): pricePerPerson = 45; break;
        case ("autumn"): pricePerPerson = 49.50; break;
        case ("winter"): pricePerPerson = 85; break;
    }
}

double totalSum = pricePerPerson * people;
if (season == "summer")
{
    totalSum *= 0.85;
}
if (season == "winter")
{
    totalSum *= 1.08;
}

//Output

Console.WriteLine($"{totalSum:f2} leva.");
