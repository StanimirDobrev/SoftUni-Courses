﻿internal class Program
{
    static void Main(string[] args)
    {
        int firstIndex = int.Parse(Console.ReadLine());
        int lastIndex = int.Parse(Console.ReadLine());
        for (int i = firstIndex; i <= lastIndex; i++)
        {
            Console.Write($"{(char)i} ");
        }
    }
}