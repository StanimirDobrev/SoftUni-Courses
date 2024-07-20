using _01.GenericBoxOfString;

namespace GenericCountMethodDouble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                box.Items.Add(input);
            }

            double valueToCompare = double.Parse(Console.ReadLine());

            int counter = box.Count(valueToCompare);
            Console.WriteLine(counter);
        }
    }
}
