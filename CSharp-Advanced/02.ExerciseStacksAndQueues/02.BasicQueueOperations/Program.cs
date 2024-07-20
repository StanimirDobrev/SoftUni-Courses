internal class Program
{
    static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>();

        int[] operators = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int elementsToEnqueue = operators[0];
        int elementsToDequeue = operators[1];
        int elementsToLook = operators[2];


        for (int i = 0; i < elementsToEnqueue; i++)
        {
            queue.Enqueue(numbers[i]);
        }

        while (queue.Any() && elementsToDequeue > 0)
        {
            queue.Dequeue();
            elementsToDequeue--;
        }

        if (queue.Contains(elementsToLook))
        {
            Console.WriteLine("true");
        }
        else if (queue.Count > 0)
        {
            Console.WriteLine(queue.Min());
        }
        else if (queue.Count == 0)
        {
            Console.WriteLine(0);
        }
    }
}