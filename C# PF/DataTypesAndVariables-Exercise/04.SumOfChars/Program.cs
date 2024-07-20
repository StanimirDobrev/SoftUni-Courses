/*
5
A
b
C
d
E
 */

internal class Program
{
    static void Main(string[] args)
    {
        int numOfChars = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < numOfChars; i++)
        {
            char letter = char.Parse(Console.ReadLine());
            
            sum += letter;
            
        }
        Console.WriteLine($"The sum equals: {sum}");
    }
}