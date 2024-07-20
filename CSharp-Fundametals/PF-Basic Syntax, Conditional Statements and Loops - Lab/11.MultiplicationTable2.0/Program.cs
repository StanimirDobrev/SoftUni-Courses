namespace _11.MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var time = int.Parse(Console.ReadLine());
           
            do
            {
                Console.WriteLine($"{num} X {time} = {num * time}");
                time++;
            } while (time <= 10);
        }
    }

}