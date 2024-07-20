
namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            RaiseToPower(input, power);

        }

        private static double RaiseToPower(int input, int power)
        {
            double result = 0d;
            result = Math.Pow(input, power);
            Console.WriteLine(result);
            return result;
        }
    }
}