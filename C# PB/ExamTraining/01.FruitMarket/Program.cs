
//Input
double priceOfStrawberries = double.Parse(Console.ReadLine());
double bananas = double.Parse(Console.ReadLine());
double oranges = double.Parse(Console.ReadLine());
double raspberries = double.Parse(Console.ReadLine());
double strawberries = double.Parse(Console.ReadLine());

//Calculations 
double sum = 0;
double priceOfRaspberries = priceOfStrawberries / 2;
double priceOfBananas = priceOfRaspberries * 0.2;
double priceOfOranges = priceOfRaspberries * 0.6;
sum += priceOfStrawberries * strawberries;
sum += priceOfRaspberries * raspberries;
sum += priceOfOranges * oranges;
sum += priceOfBananas * bananas;

//Output
Console.WriteLine($"{sum:f2}");

