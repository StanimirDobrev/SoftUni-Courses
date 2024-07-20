﻿//Input

double budget = double.Parse(Console.ReadLine());
int videoCards = int.Parse(Console.ReadLine());
int processors =  int.Parse(Console.ReadLine());
int ram =  int.Parse(Console.ReadLine());

//Calculations

double priceForVideo = videoCards * 250;
double priceForProcessors = (priceForVideo * 0.35) * processors;
double priceForRam = (priceForVideo * 0.1) * ram;
double sumOfAll = priceForVideo + priceForProcessors + priceForRam;

if (videoCards > processors)
{
    sumOfAll = sumOfAll - (sumOfAll * 0.15);
}

//Output

if (budget >= sumOfAll)
{
    Console.WriteLine($"You have {budget - sumOfAll:f2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {sumOfAll - budget:f2} leva more!");
}