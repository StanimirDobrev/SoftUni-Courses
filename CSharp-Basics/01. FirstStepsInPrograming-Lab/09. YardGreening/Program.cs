// input

double yardArea = double.Parse(Console.ReadLine());

// Calculations

double moneyNeeded = yardArea * 7.61;
double discount = moneyNeeded * 0.18;
double finalPrice = moneyNeeded - discount;

// Output

Console.WriteLine($"The final price is: {finalPrice} lv.");
Console.WriteLine($"The discount is: {discount} lv.");