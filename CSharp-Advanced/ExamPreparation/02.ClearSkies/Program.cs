
namespace _02.ClearSkies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n,n];

            int jetRow = 0;
            int jetCol = 0;

            int enemiesCount = 0;
            int armour = 300;

            for (int row = 0; row < n; row++)
            {
                string values = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    char currentValue = values[col];

                    matrix[row, col] = currentValue;

                    if (currentValue == 'J')
                    {
                        jetRow = row;
                        jetCol = col;
                    }
                    else if (currentValue == 'E')
                    {
                        enemiesCount++;
                    }
                }
            }
            while (enemiesCount > 0 && armour > 0)
            {
                string direction = Console.ReadLine();

                matrix[jetRow, jetCol] = '-';

                switch (direction)
                {
                    case "up":
                        jetRow--;
                        break;
                    case "down":
                        jetRow++;
                        break;
                    case "left":
                        jetCol--;
                        break;
                    case "right":
                        jetCol++;
                        break;
                }

                if (matrix[jetRow, jetCol] == 'E')
                {
                    enemiesCount--;
                    armour -= 100;

                    if (enemiesCount == 0 || armour == 0)
                    {
                        matrix[jetRow, jetCol] = 'J';

                        break;
                    }
                }

                if (matrix[jetRow, jetCol] == 'R')
                {
                    armour = 300;
                }

                matrix[jetRow, jetCol] = 'J';
            }

            if (armour == 0)
            {
                Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{jetRow}, {jetCol}]!");
            }
            else
            {
                Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row,col]);
                }

                Console.WriteLine();
            }
        }
    }
}
