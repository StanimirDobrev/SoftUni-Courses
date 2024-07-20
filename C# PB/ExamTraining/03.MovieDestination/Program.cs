

//Сезон	Dubai	     Sofia	    London
//Winter	45 000 lv.	17 000 lv.	24 000 lv.
//Summer	40 000 lv.	12 500 lv.	20 250 lv.

//Input
double budget = double.Parse(Console.ReadLine());
string destination = Console.ReadLine();
string season = Console.ReadLine();
double filmingDays =  double.Parse(Console.ReadLine());

//Calculations
double priceForDay = 0;
if (season == "Winter")
{
	switch (destination)
	{
		case ("Dubai"): priceForDay = 45_000; break;
		case ("Sofia"): priceForDay = 17_000; break;
		case ("London"): priceForDay = 24_000; break;	
	}
}
else if (season == "Summer")
{
    switch (destination)
    {
        case ("Dubai"): priceForDay = 40_000; break;
        case ("Sofia"): priceForDay = 12_500; break;
        case ("London"): priceForDay = 20_250; break;
    }
}
double totalSum = priceForDay * filmingDays;
if (destination == "Dubai")
{
    totalSum *= 0.7;
}
if (destination == "Sofia")
{
    totalSum *= 1.25;
}
if (budget >= totalSum)
{
    Console.WriteLine($"The budget for the movie is enough! We have {budget - totalSum:f2} leva left!");
}
else
{
    Console.WriteLine($"The director needs {totalSum - budget:f2} leva more!");
}
