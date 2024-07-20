
int stepsTarget = 10_000;
int stepsCounter = 0;

while (true) 
{ 
    string input = Console.ReadLine();

	if (input == "Going home")
	{
		int stepsToHome = int.Parse(Console.ReadLine());
		stepsCounter += stepsToHome;
		break;
	}
	else
	{
		int steps = int.Parse(input);
		stepsCounter += steps;
		if (stepsCounter >= stepsTarget)
		{
			break;
		}
	}
}

if (stepsCounter >= stepsTarget)
{
    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{stepsCounter - stepsTarget} steps over the goal!");
}
else
{
    Console.WriteLine($"{stepsTarget - stepsCounter} more steps to reach goal.");
}