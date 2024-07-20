internal class Program
{
    static void Main(string[] args)
    {
        int foodQuantity = int.Parse(Console.ReadLine());

        Queue< int> orders = new Queue< int>(Console.ReadLine()
            .Split()
            .Select(int.Parse));
        Console.WriteLine(orders.Max());

        for (int i = 0; i < orders.Count; i++)
        {
            if (foodQuantity >= orders.Peek())
            {
                foodQuantity-= orders.Peek();
                orders.Dequeue();
            }
            else
            {
                continue;
            }
            i--;
        }
        if (orders.Count == 0)
        {
            Console.WriteLine("Orders complete");
        }
        else
        {
            Console.WriteLine($"Orders left: {string.Join("", orders)}");
        }
    }
}