using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Problem2_DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(=|\/)([A-Z][A-Za-z]{2,})(\1)";
            int sum = 0;
            List<string> destinations = new List<string>();
            MatchCollection match = Regex.Matches(input, pattern);

            foreach (Match m in match)
            {
                string city = m.Groups[2].Value;
                destinations.Add(city);
                sum += city.Length;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {sum}");
        }
    }
}
