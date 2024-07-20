using Microsoft.VisualBasic;

namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]username = Console.ReadLine()
                .Split(", ")
                .ToArray();
            for (int i = 0; i < username.Length; i++)
            {
                if (IsValid(username[i]))
                {
                    Console.WriteLine(username[i]);
                }
            }
            
        }

        private static bool IsValid(string username)
        {
            if (username.Length < 3 || username.Length > 16)
            {
                return false;
            }

            for (int i = 0; i < username.Length; i++)
            {
                if (!CharIsValid(username[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool CharIsValid(char character)
        {
            return (char.IsLetter(character) || char.IsDigit(character) || character == '-' || character == '_');
        }
    }
}
