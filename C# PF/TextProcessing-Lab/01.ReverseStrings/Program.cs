internal class Program
{
    static void Main(string[] args)
    {
        string word;
        while ((word = Console.ReadLine()) != "end")
        {
            char[] wordChars = word.ToCharArray();
            char[] reversedChars = wordChars.Reverse().ToArray();
            Console.WriteLine($"{string.Join("", wordChars)} = {string.Join("", reversedChars)}");
        }
    }
}