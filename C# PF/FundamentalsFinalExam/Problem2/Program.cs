using System.Text.RegularExpressions;

namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string pattern =
                    @"^([^\s]+)>(?<first>\d{3})\|(?<second>[a-z]{3})\|(?<third>[A-Z]{3})\|(?<fourth>[^<>]+)<\1";

                if (Regex.IsMatch(input,pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    string encryptedPass = match.Groups["first"].Value + match.Groups["second"].Value + match.Groups["third"].Value + match.Groups["fourth"].Value;
                    Console.WriteLine($"Password: {encryptedPass}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
