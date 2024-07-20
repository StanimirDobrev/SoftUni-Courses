//Input
double budget = double.Parse(Console.ReadLine());
int night = int.Parse(Console.ReadLine());
double rentForNight =  double.Parse(Console.ReadLine());
double additionalCostsInPercentages = double.Parse(Console.ReadLine());

//Calculations

if (night > 7)
{
    rentForNight *= 0.95;
}
double aditionalCosts = budget * (additionalCostsInPercentages/100);
double sum = night * rentForNight + aditionalCosts;

//Output

if (budget >= sum)
{
    Console.WriteLine($"Ivanovi will be left with {budget - sum:f2} leva after vacation.");
}
else
{
    Console.WriteLine($"{sum - budget:f2} leva needed.");
}
