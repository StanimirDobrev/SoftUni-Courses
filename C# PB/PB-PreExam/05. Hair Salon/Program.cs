//input
int target = int.Parse(Console.ReadLine());


//Calculations
int price = 0;
while (true)
{
    string input = Console.ReadLine();
	if (input == "closed")
	{
		break;
	}
	if (price >= target)
	{
		break;
	}
	if (input == "haircut")
	{
		string haircutType = Console.ReadLine();
		if (haircutType == "mens")
		{
			price += 15;
		}
		else if (haircutType == "ladies")
		{
			price += 20;
		}
		else if (haircutType == "kids")
		{
			price += 10;
		}
	}
	if (input == "color")
	{
		string colorType = Console.ReadLine();
		if (colorType == "touch up")
		{
			price += 20;
		}
		else if (colorType == "full color")
		{
			price += 30;
		}
	}
}
if (price >= target)
{
    Console.WriteLine("You have reached your target for the day!");
}
else
{
    Console.WriteLine($"Target not reached! You need {Math.Abs(price - target)}lv. more.");
}
Console.WriteLine($"Earned money: {price}lv.");