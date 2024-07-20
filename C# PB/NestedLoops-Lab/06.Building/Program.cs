
int countOfFloors = int.Parse(Console.ReadLine());
int countOfRooms = int.Parse(Console.ReadLine());

for (int floors = countOfFloors; floors >= 1; floors--)
{
	for (int rooms = 0; rooms < countOfRooms; rooms++)
	{
		if (floors == countOfFloors)
		{
			Console.Write($"L{floors}{rooms} ");
		}
		else if (floors % 2 == 0)
		{
			Console.Write($"O{floors}{rooms} ");
		}
		else if (floors != 0)
		{
			Console.Write($"A{floors}{rooms} ");
		}
	}
    Console.WriteLine();
}