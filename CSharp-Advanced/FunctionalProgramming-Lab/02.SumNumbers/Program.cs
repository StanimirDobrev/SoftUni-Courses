namespace _02.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = n => int.Parse(n);
            string input = Console.ReadLine();
            int[] numbers = input.Split(new string[]{", "},StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .ToArray();

            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.Sum());

            //int[] number = Console.ReadLine()
            //    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();

            //int count = 0;
            //int sum = 0;

            //foreach (var i in number)
            //{
            //    sum += i;
            //    count ++;
            //}

            //Console.WriteLine(count);
            //Console.WriteLine(sum);
        }
    }
}
