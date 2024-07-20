//Input

int topOfFirstNumber = int.Parse(Console.ReadLine());
int topOfSecondNumber = int.Parse(Console.ReadLine());
int topOfThirdNumber = int.Parse(Console.ReadLine());

//Calculations

for (int i = 1; i <= topOfFirstNumber; i++)
{
	if (i % 2 != 0)
	{
		continue;
	}
	for (int j = 2; j <= topOfSecondNumber ; j++)
	{

		if (j == 4)
		{
			continue;
		}
		if (j == 6)
		{
			continue;
		}
		if (j == 8)
		{
			continue;
		}
		if (j > 7)
		{
			continue;
		}

		for (int k = 1; k <= topOfThirdNumber; k++)
		{
			if (k % 2 != 0)
			{
				continue;
			}
            Console.WriteLine($"{i} {j} {k}");
        }
	}
}
