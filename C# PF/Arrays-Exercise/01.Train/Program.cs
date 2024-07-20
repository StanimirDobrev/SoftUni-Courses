namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] passengers = new int[n];
            int currentNum = 0;

            for (int i = 0; i < passengers.Length; i++)
            {
                currentNum = int.Parse(Console.ReadLine());
                passengers[i] += currentNum;
                sum += currentNum;
            }

            Console.WriteLine(string.Join(" ", passengers));
            Console.WriteLine(sum);
        }
    }
}