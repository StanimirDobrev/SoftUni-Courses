internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        Stack<int> numbers = new Stack<int>(input);
        int sum = 0;

        string command;
        while ((command = Console.ReadLine().ToLower()) != "end")
        {
            string[] arguments = command.Split();
            switch (arguments[0])
            {
                case "add":
                    numbers.Push(int.Parse(arguments[1]));
                    numbers.Push(int.Parse(arguments[2]));
                    break;
                case "remove":
                    int numbersToRemove = int.Parse(arguments[1]);
                    if (numbersToRemove >= numbers.Count)
                    {
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < numbersToRemove; i++)
                        {
                            numbers.Pop();
                        }
                    }
                    break;
            }
        }
        foreach (var item in numbers)
        {
            sum += item;
        }
        Console.WriteLine($"Sum: {sum}");
    }
}