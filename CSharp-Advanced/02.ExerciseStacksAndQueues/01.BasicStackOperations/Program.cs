internal class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        int[] operators = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int elementsToPush = operators[0];
        int elementsToPop = operators[1];
        int elementsToLook = operators[2];

        for (int i = 0; i < elementsToPush; i++)
        {
            stack.Push(numbers[i]);
        }

        while (stack.Any() && elementsToPop > 0)
        {
            stack.Pop();
            elementsToPop--;
        }

        
        if (stack.Contains(elementsToLook))
        {
            Console.WriteLine("true"); 
        }
        else if (stack.Count > 0)
        {
            Console.WriteLine(stack.Min());
        }
        else if (stack.Count == 0)
        {
            Console.WriteLine(0);
        }
    }
}