
string type = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());
double income = 0;

if (type == "Premiere")
{
    income = 12;
}
else if (type == "Normal")
{
    income = 7.5;
}
else if (type == "Discount")
{
    income = 5;
}
double area = rows * columns;
double finalPrice = income * area;

Console.WriteLine($"{finalPrice:f2} leva");