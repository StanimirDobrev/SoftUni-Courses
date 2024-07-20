using _01.GenericBoxOfString;

namespace GenericCountMethodStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Box<string> box = new Box<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                box.Items.Add(input);
            }

            string valueToCompare = Console.ReadLine();

            int counter = box.Count(valueToCompare);
            Console.WriteLine(counter);
        }
    }
}
