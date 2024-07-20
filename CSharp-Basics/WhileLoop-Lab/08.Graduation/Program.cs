string name = Console.ReadLine();
int klas = 1;
int badGrades = 0;
double allGrades = 0;

while (klas <= 12)
{
    double currentGrade = double.Parse(Console.ReadLine());
    if (currentGrade < 4)
    {
        badGrades++;
        if (badGrades == 2)
        {
            Console.WriteLine($"{name} has been excluded at {klas} grade");
            return;
        }
        continue;
    }
    klas++;
    allGrades += currentGrade;
    
}
    Console.WriteLine($"{name} graduated. Average grade: {allGrades / 12:f2}");

