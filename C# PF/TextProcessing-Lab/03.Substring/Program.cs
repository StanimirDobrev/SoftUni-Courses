internal class Program
{
    static void Main(string[] args)
    {
        string filter = Console.ReadLine();
        string word = Console.ReadLine();
        while (word.Contains(filter))
        {
            int filterIndex = word.IndexOf(filter);
            word = word.Remove(filterIndex, filter.Length);
        }
        Console.WriteLine(word);
    }
}