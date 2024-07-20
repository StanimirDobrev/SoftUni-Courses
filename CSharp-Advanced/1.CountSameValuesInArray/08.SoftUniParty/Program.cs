internal class Program
{
    static void Main(string[] args)
    {
        HashSet<string> vipGuests = new HashSet<string>();
        HashSet<string> regularGuests = new HashSet<string>();

        string input;
        while ((input = Console.ReadLine()) != "PARTY") 
        {
            if (char.IsDigit(input[0]))
            {
                vipGuests.Add(input);
            }
            else
            {
                regularGuests.Add(input);
            }
        }

        while ((input = Console.ReadLine()) != "END")
        {
            if (char.IsDigit(input[0]))
            {
                vipGuests.Remove(input);
            }
            else 
            { 
                regularGuests.Remove(input);
            }
        }

        Console.WriteLine(vipGuests.Count + regularGuests.Count);

        foreach (string guest in vipGuests)
        {
            Console.WriteLine(guest);
        }
        foreach (string guest in regularGuests)
        {
            Console.WriteLine(guest);
        }
    }
}