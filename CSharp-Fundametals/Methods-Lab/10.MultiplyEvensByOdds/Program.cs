
namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int evenSum = GetSumOfEvenDigits(Math.Abs(number));
            int oddSum = GetSumOfOddDigits(Math.Abs(number));
            int result = GetMultipleOfEvenAndOdds(evenSum, oddSum);
            Console.WriteLine(result);
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            int currNum = 0;
            while (number > 0)
            {
                currNum = number % 10;
                if (currNum % 2 == 0)
                {
                    sum += currNum;
                }

                number /= 10;
            }

            return sum;
        }
        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            int currNum = 0;
            while (number > 0)
            {
                currNum = number % 10;
                if (currNum % 2 != 0)
                {
                    sum += currNum;
                }

                number /= 10;
            }
            return sum;
        }

        static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
        {
            int result = 0;
            result = evenSum * oddSum;
            return result;
        }
    }
}