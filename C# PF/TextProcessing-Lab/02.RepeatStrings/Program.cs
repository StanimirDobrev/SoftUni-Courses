internal class Program
{
    static void Main(string[] args)
    {
        string[] words = Console.ReadLine().Split();

        foreach (var word in words)
        {
            int count = word.Length;
            for (int i = 0; i < count; i++)
            {
                Console.Write(word);
            }
        }
    }
}