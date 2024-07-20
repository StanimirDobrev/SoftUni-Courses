using System.Net;
using BirthdayCelebrations.Models;
using BirthdayCelebrations.Models.Interfaces;

namespace BirthdayCelebrations
{
    public class Program
    {
        static void Main(string[] args)
        {
            var entities = new List<IBirthdate>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split();
                string className = tokens[0];
                switch (className)
                {
                    case "Citizen":
                        Citizen citizen = new Citizen(tokens[1], tokens[2], tokens[3], tokens[4]);
                        entities.Add(citizen);
                        break;
                    case "Pet":
                        Pet pet = new Pet(tokens[1], tokens[2]);
                        entities.Add(pet);
                        break;
                }
                
            }
            var suffix = Console.ReadLine();

            var detained = entities.Where(e => e.Birthdate.EndsWith(suffix)).ToArray();
            foreach (var entity in detained)
                Console.WriteLine(entity.Birthdate);

        }
    }
}
