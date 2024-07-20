internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int rowSum = 0;

        int[,] matrix = new int[input[0], input[1]];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            var columns = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = columns[col];
            }
        }

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            rowSum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                rowSum += matrix[row, col];
            }

            Console.WriteLine(rowSum);
        }
    }
}