//Input

int pages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

//Calculations
int hours = pages / pagesPerHour;
int hoursPerDay = hours/days;

//Output
Console.WriteLine(hoursPerDay);