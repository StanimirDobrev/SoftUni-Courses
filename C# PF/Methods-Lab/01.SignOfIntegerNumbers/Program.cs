namespace _01.SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsPositive();
        }

        private static bool IsPositive()
        {
            
            bool isPositive = false;
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                isPositive = true;
                Console.WriteLine($"The number {number} is positive. ");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
            else
            {
                isPositive = false;
                Console.WriteLine($"The number {number} is negative. ");
            }
            return isPositive;
        }
    }
}