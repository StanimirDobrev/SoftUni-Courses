namespace _10.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var time = 1;
            while (time <= 10)
            {
                Console.WriteLine($"{num} X {time} = {num * time}");
                time++;
            }
        }
    }
}