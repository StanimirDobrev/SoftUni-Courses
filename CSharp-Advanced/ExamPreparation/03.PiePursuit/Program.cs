namespace _03.PiePursuit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> contestants = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> pies = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            while (contestants.Count > 0 && pies.Count > 0)
            {
                int currentContestant = contestants.Dequeue();
                int currentPie = pies.Pop();

                if (currentContestant >= currentPie)
                {
                    currentContestant -= currentPie;
                    if (currentContestant > 0)
                    {
                        contestants.Enqueue(currentContestant);
                    }
                }
                else if (currentContestant < currentPie)
                {
                    currentPie -= currentContestant;
                    
                    if (currentPie == 1 && pies.Count > 0)
                    {
                        int nextpie = pies.Pop();
                        pies.Push(nextpie + currentPie);
                        continue;
                    }
                    pies.Push(currentPie);
                }
            }

            if (pies.Count == 0 && contestants.Count > 0)
            {
                Console.WriteLine("We will have to wait for more pies to be baked!");
                Console.WriteLine($"Contestants left: {string.Join(", ", contestants)}");
            }

            if (pies.Count == 0 && contestants.Count == 0)
            {
                Console.WriteLine("We have a champion!");
            }

            if (contestants.Count == 0 && pies.Count > 0)
            {
                Console.WriteLine("Our contestants need to rest!");
                Console.WriteLine($"Pies left: {string.Join(", ", pies)}");
            }
        }
    }
}
