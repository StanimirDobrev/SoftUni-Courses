﻿using System.Threading.Channels;

namespace _02.KnightsOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split().ToList();

            Action<string> print = name => Console.WriteLine("Sir " + name);

            people.ForEach(print);
        }
    }
}
