

int tabs = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

for (int i = 1; i <= tabs; i++)
{
    string name = Console.ReadLine();

	if (name == "Facebook")
	{
		salary -= 150;
	}
	else if (name == "Instagram")
	{
		salary -= 100;
	}
	else if (name == "Reddit")
	{
		salary -= 50;
	}
    if (salary == 0)
    {
        Console.WriteLine("You have lost your salary.");
    }
}
 if	(salary > 0)
{
    Console.WriteLine(salary);
}
