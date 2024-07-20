//Input

int trainingPrice = int.Parse(Console.ReadLine());

//Calculations

double priceOfShoes = trainingPrice - (trainingPrice * 0.4);
double priceOfCLothes = priceOfShoes - (priceOfShoes * 0.2);
double priceOfBall = priceOfCLothes * 0.25;
double priceOfAccessories = priceOfBall * 0.2;
double finalPrice = trainingPrice + priceOfShoes + priceOfCLothes+ priceOfBall + priceOfAccessories;

//Output
Console.WriteLine(finalPrice);