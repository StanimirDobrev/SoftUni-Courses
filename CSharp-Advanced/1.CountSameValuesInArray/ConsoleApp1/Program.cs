internal class Program
{
    static void Main(string[] args)
    {
        double[] numbers = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();

        Dictionary<double, int> numbersCount = new Dictionary<double, int>();

        foreach (var number in numbers)
        {
            if (!numbersCount.ContainsKey(number))
            {
                numbersCount.Add(number, 0);
            }
            numbersCount[number]++;
        }

        foreach (KeyValuePair<double, int> numberCount in numbersCount)
        {
            Console.WriteLine($"{numberCount.Key} - {numberCount.Value} times");
        }
    }
}