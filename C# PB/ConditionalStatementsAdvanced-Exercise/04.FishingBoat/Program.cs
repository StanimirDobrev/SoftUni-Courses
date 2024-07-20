//Input

int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fisherman =  int.Parse(Console.ReadLine());

double rentForBoat = 0;
//Calculations
if (season == "Spring")
{
    rentForBoat = 3000;
    if (fisherman <= 6)
    {
        rentForBoat *= 0.9;
        if (fisherman % 2 == 0)
        {
            rentForBoat *= 0.95;
        }
    }
    else if (fisherman >= 7 && fisherman <= 11)
    {
        rentForBoat *= 0.85;
        if (fisherman % 2 == 0)
        {
            rentForBoat *= 0.95;
        }
    }
    else if (fisherman > 12)
    {
        rentForBoat *= 0.75;
        if (fisherman % 2 == 0)
        {
            rentForBoat *= 0.95;
        }
    }
}
else if (season == "Summer")
{
    rentForBoat = 4200;
    if (fisherman <= 6)
    {
        rentForBoat *= 0.9;
        if (fisherman % 2 == 0)
        {
            rentForBoat *= 0.95;
        }
    }
    else if (fisherman >=7 && fisherman <= 11)
    {
        rentForBoat *= 0.85;
        if (fisherman % 2 == 0)
        {
            rentForBoat *= 0.95;
        }
    }
    else if (fisherman > 12)
    {
        rentForBoat *= 0.75;
        if (fisherman % 2 == 0)
        {
            rentForBoat *= 0.95;
        }
    }
}
else if (season == "Autumn")
{
    rentForBoat = 4200;
    if (fisherman <= 6)
    {
        rentForBoat *= 0.9;

    }
    else if (fisherman >= 7 &&fisherman <= 11)
    {
        rentForBoat *= 0.85;

    }
    else if (fisherman > 12)
    {
        rentForBoat *= 0.75;

    }
}
else if (season == "Winter")
{
    rentForBoat = 2600;
    if (fisherman <= 6)
    {
        rentForBoat *= 0.9;
        if (fisherman % 2 == 0)
        {
            rentForBoat *= 0.95;
        }
    }
    else if (fisherman >= 7 && fisherman <= 11)
    {
        rentForBoat *= 0.85;
        if (fisherman % 2 == 0)
        {
            rentForBoat *= 0.95;
        }
    }
    else if (fisherman > 12)
    {
        rentForBoat *= 0.75;
        if (fisherman % 2 == 0)
        {
            rentForBoat *= 0.95;
        }
    }
}
//Output
if (budget > rentForBoat)
{
    Console.WriteLine($"Yes! You have {budget - rentForBoat:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {rentForBoat - budget:f2} leva.");
}
