namespace _01ChickenSnack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> money = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Queue<int> food = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int foodEatenCount = 0;

            while (money.Any() && food.Any())
            {
                int currentMoney = money.Pop();
                int currentFood = food.Dequeue();
                if (currentMoney < currentFood)
                {
                    continue;
                }
                else if (currentMoney == currentFood)
                {
                    foodEatenCount++;
                    continue;
                }
                else
                {
                    int diff = currentMoney - currentFood;
                    if (money.Count > 0)
                    {
                        currentMoney = diff + money.Pop();
                    }

                    money.Push(currentMoney);
                    foodEatenCount++;
                }
            }

            if (foodEatenCount >= 4)
            {
                Console.WriteLine($"Gluttony of the day! Henry ate {foodEatenCount} foods.");
            }
            else if (foodEatenCount == 1)
            {
                Console.WriteLine($"Henry ate: {foodEatenCount} food.");
            }
            else if (foodEatenCount > 0)
            {
                Console.WriteLine($"Henry ate: {foodEatenCount} foods.");
            }
            else
            {
                Console.WriteLine($"Henry remained hungry. He will try next weekend again.");
            }
        }
    }
}
