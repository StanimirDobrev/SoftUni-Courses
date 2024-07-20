using System.Text.Json;

internal class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());

        char[,] matrix = new char[input, input];
        for (int row = 0; row < input; row++)
        {
            var values = Console.ReadLine();
            
            for (int col = 0; col < input; col++)
            {
                matrix[row, col] = values[col];
            }
        }

        char keyChar = char.Parse(Console.ReadLine());

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row,col].Equals(keyChar))
                {
                    Console.WriteLine($"({row}, {col})");
                    return;
                }
                
            }
        }
        Console.WriteLine($"{keyChar} does not occur in the matrix");
    }
}