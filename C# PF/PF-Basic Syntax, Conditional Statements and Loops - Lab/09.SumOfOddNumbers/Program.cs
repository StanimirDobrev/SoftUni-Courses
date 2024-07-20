namespace _09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int current = 2 * i - 1;
                sum += current;
                Console.WriteLine(current);
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}