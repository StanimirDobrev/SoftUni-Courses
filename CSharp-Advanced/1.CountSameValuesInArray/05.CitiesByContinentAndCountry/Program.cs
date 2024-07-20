internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, Dictionary<string, List<string>>> continents =
            new Dictionary<string, Dictionary<string, List<string>>>();

        for (int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string continent = tokens[0];
            string country = tokens[1];
            string city = tokens[2];

            if (!continents.ContainsKey(continent))
            {
                continents.Add(continent, new Dictionary<string, List<string>>());
            }

            if (!continents[continent].ContainsKey(country))
            {
                continents[continent].Add(country, new List<string>());
            }

            continents[continent][country].Add(city);
        }

        foreach ((string continent, Dictionary<string,List<string>> countries) in continents)
        {
            Console.WriteLine($"{continent}:");
            foreach ((string country, List<string> cities) in countries)
            {
                Console.WriteLine($"  {country} -> {string.Join(", ", cities)}");
            }
        }
    }
}