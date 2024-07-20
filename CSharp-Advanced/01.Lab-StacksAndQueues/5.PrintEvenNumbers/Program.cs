internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Queue<int> evenNumbers = new Queue<int>();

        foreach (var item in input)
        {
            if (item % 2 == 0)
            {
                evenNumbers.Enqueue(item);
            }
        }

        Console.WriteLine(string.Join(", ", evenNumbers));
    }
}