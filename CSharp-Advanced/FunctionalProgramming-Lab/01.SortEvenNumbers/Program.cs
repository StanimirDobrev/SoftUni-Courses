namespace _01.SortEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(i => i % 2 == 0)
                .OrderBy(i => i)
                .ToArray();

            Console.WriteLine(string.Join(", ", input));
        }
    }
}
