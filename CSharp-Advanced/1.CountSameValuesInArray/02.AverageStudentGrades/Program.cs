internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

        for (int i = 0; i < n; i++)
        {
            string[] currentStudent = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string studentName = currentStudent[0];
            decimal studentGrade = decimal.Parse(currentStudent[1]);

            if (!students.ContainsKey(studentName))
            {
                students.Add(studentName, new List<decimal>());
            }

            students[studentName].Add(studentGrade);
        }

        foreach ((string student, List<decimal> grades) in students)
        {
            string gradesStr = string.Join(" ", grades.Select(v => v.ToString("f2")));
            string average = $"(avg: {grades.Average():f2})";

            Console.WriteLine($"{student} -> {gradesStr} {average}");
        }
    }
}