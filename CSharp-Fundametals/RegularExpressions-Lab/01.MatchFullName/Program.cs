using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string name = Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(name, pattern);

            foreach (Match match in matchedNames)
            {
                Console.Write($"{match.Value} ");
            }
            Console.WriteLine();
        }
    }
}
