namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] arguments = command.Split();

                switch (arguments[0])
                {
                    case "Change":
                        string currentChar = arguments[1];
                        string replacement = arguments[2];
                        input = input.Replace(currentChar, replacement);
                        Console.WriteLine(input);
                        break;
                    case "Includes":
                        string substring = arguments[1];
                        bool includes = false;
                        if (input.Contains(substring))
                        {
                            includes = true;
                            Console.WriteLine(includes);
                        }
                        else
                        {
                            Console.WriteLine(includes);
                        }
                        break;
                    case "End":
                        string endSubstring = arguments[1];
                        bool isEnding = false;
                        if (input.EndsWith(endSubstring))
                        {
                            isEnding = true;
                            Console.WriteLine(isEnding);
                        }
                        else
                        {
                            Console.WriteLine(isEnding);
                        }
                        break;
                    case "Uppercase":
                        input = input.ToUpper();
                        Console.WriteLine(input);
                        break;
                    case "FindIndex":
                        char findChar = char.Parse(arguments[1]);
                        int index = input.IndexOf(findChar);
                        Console.WriteLine(index);
                        break;
                    case "Cut":
                        int startIndex = int.Parse(arguments[1]);
                        int count = int.Parse(arguments[2]);
                        string cutedString = input.Substring(startIndex, count);
                        Console.WriteLine(cutedString);
                        //input = input.Remove(startIndex, count);
                        break;
                }
            }
        }
    }
}
