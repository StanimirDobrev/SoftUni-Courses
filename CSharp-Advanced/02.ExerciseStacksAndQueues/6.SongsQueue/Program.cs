internal class Program
{
    static void Main(string[] args)
    {
        Queue<string> songsList = new Queue<string>(Console.ReadLine()
            .Split(", "));

        while (songsList.Any())
        {
            string[] input = Console.ReadLine()
                .Split();
            string command = input[0];

            switch (command)
            {
                case "Play":
                    songsList.Dequeue();
                    break;
                case "Add":
                    string newSong = string.Join(" ", input.Skip(1));
                    if (songsList.Contains(newSong))
                    {
                        Console.WriteLine($"{newSong} is already contained!");
                    }
                    else
                    {
                        songsList.Enqueue(newSong);
                    }
                    break;
                case "Show":
                    Console.WriteLine(string.Join(", ", songsList));
                    break;
            }
        }

        Console.WriteLine("No more songs!");
    }
}