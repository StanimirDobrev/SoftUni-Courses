//Input
int naylon = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int paintThinner = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

//Calculations
double priceOfNaylon = (naylon + 2) * 1.5;
double priceOfPaint = (paint + 1.1) * 14.5;
double priceOfPaintThinner = paintThinner * 5;
double priceOfMaterials = priceOfNaylon + priceOfPaint + priceOfPaintThinner + 0.4;
double priceForCraftsmen = (priceOfMaterials * 0.3) * hours;
double finalPrice = priceOfMaterials + priceForCraftsmen;

//Output
Console.WriteLine(finalPrice);
