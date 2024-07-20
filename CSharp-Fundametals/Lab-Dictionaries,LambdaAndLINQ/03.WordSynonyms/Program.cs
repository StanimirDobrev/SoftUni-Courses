internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        var words = new Dictionary<string, List<string>>();

        for (int i = 0; i < n; i++)
        {
            string word = Console.ReadLine();
            string synonym = Console.ReadLine();
            if (!words.ContainsKey(word))
            {
                words.Add(word, new List<string>());
            }
            words[word].Add(synonym);
        }

        foreach (KeyValuePair<string, List<string>> word in words)
        {
            Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
        }
    }
}