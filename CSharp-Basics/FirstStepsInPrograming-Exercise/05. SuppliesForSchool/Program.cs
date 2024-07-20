// Input
int pen = int.Parse(Console.ReadLine());
int markers = int.Parse(Console.ReadLine());
int glassCleaner = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

// Calculation
double priceOfPen = pen * 5.8;
double priceOfMarkers = markers * 7.2;
double priceOfGlassCleaner = glassCleaner * 1.2;
double price = priceOfPen + priceOfMarkers + priceOfGlassCleaner;
double priceWithDiscount = price - (price * discount / 100);

//Output
Console.WriteLine(priceWithDiscount);