internal class Program
{
    static void Main(string[] args)
    {

        int input = int.Parse(Console.ReadLine());
              

        int[,] matrix = new int[input, input];

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

    }
}