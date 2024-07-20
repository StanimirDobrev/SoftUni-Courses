using System.Text;

namespace Problem1_Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder sb = new StringBuilder(Console.ReadLine());
            string user = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "Registration")
            {
                string[] command = input.Split();

                switch (command[0])
                {
                    case "Letters":
                        if (command[1] == "Lower")
                        {
                            user = user.ToLower();
                        }
                        else
                        {
                            user = user.ToUpper();
                        }
                        Console.WriteLine(user);
                        break;
                    case "Reverse":
                        
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        if (startIndex >= 0 && endIndex <= user.Length)
                        {
                            string reverted = user.Substring(startIndex, endIndex - startIndex + 1);
                            char[] charRev = reverted.ToCharArray();
                            Array.Reverse(charRev);
                            string reversedString = new string(charRev);
                            Console.WriteLine(reversedString);
                        }
                        break;
                    case "Substring":
                        string substring = command[1];
                        if (user.Contains(substring))
                        {
                            user = user.Replace(substring, "");
                            Console.WriteLine(user);
                        }
                        else
                        {
                            Console.WriteLine($"The username {user} doesn't contain {substring}.");
                        }
                        break;
                    case "Replace":
                        char givenChar = char.Parse(command[1]);
                        user = user.Replace(givenChar, '-');
                        Console.WriteLine(user);
                        break;
                    case "IsValid":
                        char validChar = char.Parse(command[1]);
                        if (user.Contains(validChar))
                        {
                            Console.WriteLine("Valid username.");
                        }
                        else
                        {
                            Console.WriteLine($"{validChar} must be contained in your username.");
                        }
                        break;
                }
            }
        }
    }
}
