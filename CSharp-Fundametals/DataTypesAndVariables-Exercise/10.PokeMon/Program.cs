internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        double percent = n * 0.5;
        int pokeCount = 0;

        while (n >= m)
        {
            pokeCount++;
            n -= m;
            if (n == percent && y != 0)
            {
                n /= y;
            }
        }
        Console.WriteLine(n);
        Console.WriteLine(pokeCount);
    }
}