using System.Text.RegularExpressions;

namespace Problem2_MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(@|\#)(?<wordOne>[A-Za-z]{2,})(\1)(\1)(?<wordTwo>[A-Za-z]{2,})(\1)";
            int pairs = 0;

            MatchCollection match = Regex.Matches(input, pattern);

            foreach (Match m in match)
            {
                string wordOne = m.Groups["wordOne"].Value;
                string wordTwo = m.Groups["wordTwo"].Value;
                
                if (wordOne == wordTwo.Reverse())
                {
                    
                }
            }
        }
    }
}
