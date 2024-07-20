// Input
string actorsName = Console.ReadLine();
double points = double.Parse(Console.ReadLine());
int judges = int.Parse(Console.ReadLine());

//Calculations
for (int i = 0; i < judges; i++)
{
    string judgesName = Console.ReadLine();
    double judgesPoints = double.Parse(Console.ReadLine());

    points += judgesName.Length * judgesPoints / 2;

    if (points > 1250.5)
    {
        break;
    }
}
// Output

if (points > 1250.5)
{
    Console.WriteLine($"Congratulations, {actorsName} got a nominee for leading role with {points:f1}!");

}
else
{
    Console.WriteLine($"Sorry, {actorsName} you need {1250.5 - points:f1} more!");
}