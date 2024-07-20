internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        SortedSet<string> set = new SortedSet<string>();

        for (int i = 0; i < n; i++)
        {
            List<string> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            for (int j = 0; j < input.Count; j++)
            {
                set.Add(input[j]);
            }
        }
        Console.WriteLine(string.Join(' ', set));
    }
}