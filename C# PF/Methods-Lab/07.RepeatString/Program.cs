namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            RepeatString(str, count);
        }

        static string RepeatString(string str, int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                Console.Write(str);
            }
            return result;
        }
    }
}