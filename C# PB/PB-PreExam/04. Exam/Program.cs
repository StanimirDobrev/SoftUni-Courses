//Input
int students = int.Parse(Console.ReadLine());

//Calculations

double group1 = 0;
double group2 = 0;
double group3 = 0;
double group4 = 0;
double averageCount = 0;
for (int i = 0; i < students; i++)
{
    double grade = double.Parse(Console.ReadLine());

	if (grade >= 5.00)
	{
		group1++;
	}
	else if (grade >=4.00 && grade <= 4.99)
	{
		group2++;
	}
	else if (grade >= 3.00 && grade <= 3.99)
	{
		group3++;
	}
	else if (grade < 3.00)
	{
		group4++;
	}
	averageCount += grade;
}
double averageSum = averageCount / students;
group1 = group1 / students * 100;
group2 = group2 / students * 100;
group3 = group3 / students * 100;
group4 = group4 / students * 100;

//Output
Console.WriteLine($"Top students: {group1:f2}%");
Console.WriteLine($"Between 4.00 and 4.99: {group2:f2}%");
Console.WriteLine($"Between 3.00 and 3.99: {group3:f2}%");
Console.WriteLine($"Fail: {group4:f2}%");
Console.WriteLine($"Average: {averageSum:f2}");