
double neededMoney = double.Parse(Console.ReadLine());
double ownedMoney = double.Parse(Console.ReadLine());
string input = "";
double money = 0;
int daysCount = 0;
int spendCount = 0;


while (ownedMoney < neededMoney)
{
    input = Console.ReadLine();
    money = double.Parse(Console.ReadLine());
    daysCount++;
    if (input == "save")
    {
        ownedMoney += money;
    }
    else
    {
       ownedMoney -= money;
    }


}
