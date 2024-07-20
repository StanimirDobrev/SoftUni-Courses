using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        Queue<string> kids = new Queue<string>(Console.ReadLine().Split());
        int passes = int.Parse(Console.ReadLine());

        while (kids.Count > 1)
        {
            for (int i = 0; i < passes - 1; i++)
            {
                kids.Enqueue(kids.Dequeue());
            }

            Console.WriteLine($"Removed {kids.Dequeue()}");
        }

        Console.WriteLine($"Last is {kids.Dequeue()}");
    }
}