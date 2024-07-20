internal class Program
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        string letters = string.Empty;
        string digits = string.Empty;
        string others = string.Empty;

        for (int i = 0; i < text.Length; i++)
        {
            char curentChar = text[i];

            if (char.IsDigit(curentChar))
            {
                digits += curentChar;
            }
            else if (char.IsLetter(curentChar))
            {
                letters += curentChar;
            }
            else
            {
                others += curentChar;
            }
        }
        Console.WriteLine(digits);
        Console.WriteLine(letters);
        Console.WriteLine(others);
    }
}