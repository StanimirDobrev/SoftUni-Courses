internal class Program
{
    static void Main(string[] args)
    {
        SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

        string command;
        while ((command = Console.ReadLine()) != "Revision")
        {
            string[] tokens = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string shop = tokens[0];
            string product = tokens[1];
            double price = double.Parse(tokens[2]);

            if (!shops.ContainsKey(shop))
            {
                shops[shop] = new Dictionary<string, double>();
            }
            shops[shop].Add(product, price);
        }

        foreach ((string shop, Dictionary<string, double> products) in shops)
        {
            Console.WriteLine($"{shop}->");

            foreach ((string product, double price) in products)
            {
                Console.WriteLine($"Product: {product}, Price: {price}");
            }
        }
    }
}