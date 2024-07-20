
string input = Console.ReadLine();
double sum = 0;
while (input != "NoMoreMoney")
{
    
    double number = double.Parse(input);
	if (number < 0 )
	{
        Console.WriteLine("Invalid operation!");
        break;
    }
    Console.WriteLine($"Increase: {number:f2}");
    sum += number;
    input = Console.ReadLine();
}
Console.WriteLine($"Total: {sum}");