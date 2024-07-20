internal class Program
{
    static void Main(string[] args)
    {
        double meters = double.Parse(Console.ReadLine());
        double kilometers = meters / 100;
        Console.WriteLine($"{kilometers:f2}");

    }
}