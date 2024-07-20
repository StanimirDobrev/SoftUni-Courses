using System.Numerics;

namespace _04.EscapeTheMaze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            int health = 100;
            int playerRow = -1;
            int playerCol = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string tokens = Console.ReadLine();


                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = tokens[col];

                    if (tokens[col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            while (true)
            {
                string direction = Console.ReadLine();
                int nextRow = 0;
                int nextCol = 0;
                switch (direction)
                {
                    case "up":
                        nextRow = -1;
                        break;
                    case "down":
                        nextRow = +1;
                        break;
                    case "left":
                        nextCol = -1;
                        break;
                    case "right":
                        nextCol = 1;
                        break;
                }

                if (!IsInside(matrix, playerRow + nextRow, playerCol + nextCol))
                {
                    continue;
                }

                matrix[playerRow, playerCol] = '-';
                playerRow += nextRow;
                playerCol += nextCol;

                if (matrix[playerRow,playerCol] == 'M')
                {
                    health -= 40;
                    if (health <= 0)
                    {
                        health = 0;
                        matrix[playerRow, playerCol] = 'P';
                        break;
                    }
                }

                if (matrix[playerRow, playerCol] == 'H')
                {
                    health += 15;
                    if (health > 100)
                    {
                        health = 100;
                    }
                }

                if (matrix[playerRow, playerCol] == 'X')
                {
                    matrix[playerRow, playerCol] = 'P';
                    break;
                }
            }

            if (health <= 0)
            {
                Console.WriteLine("Player is dead. Maze over!");
            }
            else
            {
                Console.WriteLine("Player escaped the maze. Danger passed!");
            }
            Console.WriteLine($"Player's health: {health} units");

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row,col]);
                }

                Console.WriteLine();
            }
        }

        public static bool IsInside(char[,] matrix, int row, int col)
        => row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
    }
}
