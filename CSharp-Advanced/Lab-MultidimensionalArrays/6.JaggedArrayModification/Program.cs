namespace _6.JaggedArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArr = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                jaggedArr[i] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] arguments = command.Split();
                string action = arguments[0];
                int row = int.Parse(arguments[1]);
                int col = int.Parse(arguments[2]);
                int value = int.Parse(arguments[3]);

                if (row < 0 || row > rows || col < 0 || col >= jaggedArr[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                switch (action)
                {
                    case "Add":
                        jaggedArr[row][col] += value;
                        break;
                    case "Subtract":
                        jaggedArr[row][col] -= value;
                        break;
                    default:
                        break;
                }
            }

            foreach (var asd in jaggedArr)
            {
                Console.WriteLine(string.Join(" ", asd));
            }
        }
    }
}
