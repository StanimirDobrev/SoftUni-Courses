//Input
int age = int.Parse(Console.ReadLine());
double washingMachinePrice = double.Parse(Console.ReadLine());
int toysPrice = int.Parse(Console.ReadLine());

//Calculations
int sum = 0;
int moneyToBeRecieved = 10;
for (int currentAge = 1; currentAge <= age; currentAge++)
{
	if (currentAge % 2 == 0)
	{
		sum += moneyToBeRecieved - 1;
		moneyToBeRecieved += 10;
	}
	else
	{
		sum += toysPrice;	
	}
}
if (sum >= washingMachinePrice)
{
	Console.WriteLine($"Yes! {sum - washingMachinePrice:f2}");
}
else
{
    Console.WriteLine($"No! {washingMachinePrice - sum:f2}");
}



