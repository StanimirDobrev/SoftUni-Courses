namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PriceSum();
        }
        //•	coffee – 1.50
        //•	water – 1.00
        //•	coke – 1.40
        //•	snacks – 2.00

        private static void PriceSum()
        {
            string product = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double sum = 0;
            switch (product)
            {
                case "coffee":
                    sum = quantity * 1.50;
                    Console.WriteLine($"{sum:f2}");
                    break;
                case "water":
                    sum = quantity * 1.00;
                    Console.WriteLine($"{sum:f2}");
                    break;
                case "coke":
                    sum = quantity * 1.40;
                    Console.WriteLine($"{sum:f2}");
                    break;
                case "snacks":
                    sum = quantity * 2.00;
                    Console.WriteLine($"{sum:f2}");
                    break;
            }
        }
    }
}