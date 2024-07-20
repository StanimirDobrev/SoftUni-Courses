namespace Problem1_TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] arguments = command.Split("|");

                switch (arguments[0])
                {
                    case "Move":
                        int numberOfLetters = int.Parse(arguments[1]);
                        string firstLetters = message.Substring(0, numberOfLetters);
                        message = message.Remove(0, numberOfLetters);
                        message += firstLetters;
                        break;
                    case "Insert":
                        int index = int.Parse(arguments[1]);
                        string insertingValue = arguments[2];
                        message = message.Insert(index, insertingValue);
                        break;
                    case "ChangeAll":
                        string substring = arguments[1];
                        string replacement = arguments[2];
                        message = message.Replace(substring, replacement);
                        break;
                }
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
