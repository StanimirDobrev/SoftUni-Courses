namespace _04.AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> vat = x => x * 1.2;
            
            double[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(vat)
                .ToArray();

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number:f2}");
            }
        }
    }
}
