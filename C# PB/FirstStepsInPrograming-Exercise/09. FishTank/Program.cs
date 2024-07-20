//Input

int lenght = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int  height = int.Parse(Console.ReadLine());
double spaceTaken = double.Parse(Console.ReadLine())/100;

//Calculations

double fullSpace = lenght * width * height;
double fullSpaceLt = fullSpace * 0.001;
double litresNeeded = fullSpaceLt * (1 - spaceTaken);

//Output
Console.WriteLine(litresNeeded);
