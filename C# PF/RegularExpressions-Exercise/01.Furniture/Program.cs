using System.Text.RegularExpressions;

namespace _01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Furniture> furnitures = new List<Furniture>();

            string pattern = @">>(?<Name>[A-Za-z]+)<<(?<Price>\d+.\d+|\d+)!(?<Quantity>\d+)";

            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                foreach (Match match in Regex.Matches(input, pattern))
                {
                    Furniture furniture = new Furniture();
                    furniture.Name = match.Groups["Name"].Value;
                    furniture.Price = decimal.Parse(match.Groups["Price"].Value);
                    furniture.Quantity = uint.Parse(match.Groups["Quantity"].Value);

                    furnitures.Add(furniture);
                }
            }

            decimal totalSpent = 0m;
            Console.WriteLine("Bought furniture:");
            foreach (Furniture furniture in furnitures)
            {
                Console.WriteLine(furniture.Name);
                totalSpent += furniture.Total;
            }

            Console.WriteLine($"Total money spend: {totalSpent:f2}");
        }
    }

    class Furniture
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public uint Quantity { get; set; }
        public decimal Total
        {
            get { return Price * Quantity; }
        }
    }
}
