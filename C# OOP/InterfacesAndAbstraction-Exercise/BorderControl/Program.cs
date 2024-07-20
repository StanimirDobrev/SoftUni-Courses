
using BorderControl.Models;
using BorderControl.Models.Interfaces;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            var entities = new List<IIdentifiable>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split();

                if (tokens.Length == 3)
                {
                    Citizen citizen = new Citizen(tokens[0], tokens[1], tokens[2]);
                    entities.Add(citizen);
                }
                else if (tokens.Length == 2)
                {
                    Robot robot = new Robot(tokens[0], tokens[1]);
                    entities.Add(robot);
                }
            }
            var suffix = Console.ReadLine();

            var detained = entities.Where(e => e.Id.EndsWith(suffix)).ToArray();
            foreach (var entity in detained)
                Console.WriteLine(entity.Id);
            
        }
    }
}
 