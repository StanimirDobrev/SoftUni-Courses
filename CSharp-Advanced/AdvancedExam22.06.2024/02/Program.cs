using System.Drawing;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int energy = 15;
            int beeRow = 0;
            int beeCol = 0;
            int nectarCollected = 0;
            bool energyRestored = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];

                    if (input[col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                    }
                }
            }

            while (true)
            {
                matrix[beeRow, beeCol] = '-';
                energy--;
                
                string command = Console.ReadLine();
                switch (command)
                {
                    case "up": beeRow = (beeRow == 0) ? n - 1 : beeRow - 1; break;
                    case "down": beeRow = (beeRow == n - 1) ? 0 : beeRow + 1; break;
                    case "left": beeCol = (beeCol == 0) ? n - 1 : beeCol - 1; break;
                    case "right": beeCol = (beeCol == n - 1) ? 0 : beeCol + 1; break;
                }
                char currentPosition = matrix[beeRow, beeCol];

                if (char.IsDigit(currentPosition))
                {
                    nectarCollected += currentPosition - '0';
                }
                else if (currentPosition == 'H')
                {
                    if (nectarCollected >= 30)
                    {
                        Console.WriteLine($"Great job, Beesy! The hive is full. Energy left: {energy}");
                        matrix[beeRow, beeCol] = 'B';
                        PrintField(matrix, n);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Beesy did not manage to collect enough nectar.");
                        matrix[beeRow, beeCol] = 'B';
                        PrintField(matrix, n);
                        return;
                    }
                }
                if (energy == 0)
                {
                    if (nectarCollected >= 30 && !energyRestored)
                    {
                        energy = nectarCollected - 30;
                        nectarCollected = 30;
                        energyRestored = true;
                    }
                    else
                    {
                        Console.WriteLine("This is the end! Beesy ran out of energy.");
                        matrix[beeRow, beeCol] = 'B';
                        PrintField(matrix, n);
                        return;
                    }
                }

                matrix[beeRow, beeCol] = 'B';
            }
        }

        private static void PrintField(char[,] matrix, int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
