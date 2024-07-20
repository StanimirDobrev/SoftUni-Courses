internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < n; i++)
        {
            string[] array = Console.ReadLine()
                .Split();
                

            string command = array[0];
            
            

            switch (command)
            {
                    
                case "1":
                    int numberToUse = int.Parse(array[1]);
                    stack.Push(numberToUse);
                    break;
                case "2":
                    stack.Pop();
                    break;
                case "3":
                    Console.WriteLine(stack.Max());
                    break;
                case "4":
                    Console.WriteLine(stack.Min());
                    break;
            }
        }

        Console.WriteLine(string.Join(", ", stack));
    }
}