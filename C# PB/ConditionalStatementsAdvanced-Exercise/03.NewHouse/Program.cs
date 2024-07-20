// Input
//Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
using System.Security.Cryptography;

string flowersType = Console.ReadLine();
int flowersCount = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());
double flowersPrice = 0;

//Calculations

switch (flowersType)
{
    case "Roses": flowersPrice = 5; break;
    case "Dahlias": flowersPrice = 3.8; break;
    case "Tulips": flowersPrice = 2.8; break;
    case "Narcissus": flowersPrice = 3; break;
    case "Gladiolus": flowersPrice = 2.5; break;
}
double totalCost = flowersPrice * flowersCount;

if (flowersType == "Roses" && flowersCount > 80)
{
    totalCost *= 0.9;
}
else if (flowersType == "Dahlias" && flowersCount > 90)
{
    totalCost *= 0.85;
}
else if (flowersType == "Tulips" && flowersCount > 80)
{
    totalCost *= 0.85;
}
else if (flowersType == "Narcissus" && flowersCount < 120)
{
    totalCost *= 1.15;
}
else if (flowersType == "Gladiolus" && flowersCount < 80) 
{
    totalCost *= 1.20;
}
if (budget >= totalCost)
{
    Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {budget - totalCost:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {totalCost - budget:f2} leva more.");
}