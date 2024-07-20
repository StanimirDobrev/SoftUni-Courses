internal class Program
{
    static void Main(string[] args)
    {
        decimal pounds = decimal.Parse(Console.ReadLine());
        decimal dollars = 0;
        dollars = decimal.Multiply(pounds, 1.31m);
        Console.WriteLine($"{dollars:f3}");
    }
}