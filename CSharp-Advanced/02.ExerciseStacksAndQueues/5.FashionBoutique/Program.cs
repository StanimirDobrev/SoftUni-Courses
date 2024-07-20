internal class Program
{
    static void Main(string[] args)
    {
        Stack<int> clothes = new Stack<int>(Console.ReadLine()
            .Split()
            .Select(int.Parse));

        int singleRackCapacity = int.Parse(Console.ReadLine());
        int rackCount = 1;
        int currentRackCapacity = 0;

        while (clothes.Any())
        {
            int currentClothe = clothes.Pop();
            if (currentClothe + currentRackCapacity <= singleRackCapacity)
            {
                currentRackCapacity += currentClothe;
            }
            else
            {
                rackCount++;
                currentRackCapacity = currentClothe;
            }
        }
        Console.WriteLine(rackCount);
    }
}