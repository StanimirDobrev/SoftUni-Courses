/*
 
5
20
100
100
100
20
 */
internal class Program
{
    static void Main(string[] args)
    {
        int linesCount = int.Parse(Console.ReadLine());
        int litresSum = 0;
        for (int i = 0; i < linesCount; i++)
        {
            int litres = int.Parse(Console.ReadLine());
            if (litresSum + litres > 255)
            {
                Console.WriteLine("Insufficient capacity!");
            }
            else
            {
                litresSum += litres;
            }
            
            
        }
        Console.WriteLine(litresSum);
    }
}