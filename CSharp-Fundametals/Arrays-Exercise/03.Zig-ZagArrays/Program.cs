namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int[] evenNum = new int[count];
            int[] oddNum = new int[count];

            for (int i = 0; i < count; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                if (i % 2 == 0)
                {
                    evenNum[i] += numbers[0];
                    oddNum[i] += numbers[1];
                }
                else
                {
                    evenNum[i] += numbers[1];
                    oddNum[i] += numbers[0];
                }
            }

            Console.WriteLine(string.Join(" ", evenNum));
            Console.WriteLine(string.Join(" ", oddNum));
        }
    }
}