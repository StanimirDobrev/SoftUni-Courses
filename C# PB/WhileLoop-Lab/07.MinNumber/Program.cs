
string input = Console.ReadLine();
int minNumber = int.MaxValue;
while (input != "Stop")
{
    int number = int.Parse(input);

    if (number < minNumber)
    {
        minNumber = number;
    }

    input = Console.ReadLine();
}
Console.WriteLine(minNumber);