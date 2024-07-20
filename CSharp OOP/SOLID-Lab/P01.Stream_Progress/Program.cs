using System;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            StreamProgressInfo fileProgress = new(new File("Ivan", 5, 100));
            StreamProgressInfo musicProgress = new(new Music("Ivan","Sar bobos", 5, 100));
            Console.WriteLine(fileProgress.CalculateCurrentPercent());
            Console.WriteLine(musicProgress.CalculateCurrentPercent());
        }
    }
}
