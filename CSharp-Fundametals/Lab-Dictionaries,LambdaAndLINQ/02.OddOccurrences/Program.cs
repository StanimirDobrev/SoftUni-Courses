﻿internal class Program
{
    static void Main(string[] args)
    {
        string[] words = Console.ReadLine()
            .Split();

        Dictionary<string, int> counts = new Dictionary<string, int>();
        foreach (string word in words)
        {
            string wordInLowerCase = word.ToLower();

            if (counts.ContainsKey(wordInLowerCase))
            {
                counts[wordInLowerCase]++;
            }
            else
            {
                counts.Add(wordInLowerCase, 1);
            }
        }

        foreach (KeyValuePair<string, int> count in counts)
        {
            if (count.Value % 2 != 0)
            {
                Console.Write(count.Key + " ");
            }
        }
    }
}