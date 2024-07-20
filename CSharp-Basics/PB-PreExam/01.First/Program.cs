//Input

int people = int.Parse(Console.ReadLine());
int nights =  int.Parse(Console.ReadLine());
int transportCards =  int.Parse(Console.ReadLine());
int tickets =  int.Parse(Console.ReadLine());

//Calculations
int priceForNight = nights * 20;
double transportCardsPrice = transportCards * 1.6;
int ticketsPrice = tickets * 6;
double sumPerPerson = priceForNight + transportCardsPrice + ticketsPrice;
double totalSum = sumPerPerson * people * 1.25;
//Output

Console.WriteLine($"{totalSum:f2}");