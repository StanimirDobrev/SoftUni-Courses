namespace _09GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int firstInt = int.Parse(Console.ReadLine());
                    int secondtInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstInt, secondtInt));
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstChar, secondChar));
                    break;
                case "string":
                    string firstStr = Console.ReadLine();
                    string secondStr = Console.ReadLine();
                    Console.WriteLine(GetMax(firstStr, secondStr));
                    break;
            }
        }

        static int GetMax(int first, int second)
        {

            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static char GetMax(char first, char second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static string GetMax(string first, string second)
        {
            int result = first.CompareTo(second);

            if (result > 0)
            {
                return first;
            }

            return second;
        }
    }
}