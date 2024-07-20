using System.Text;

namespace Problem1_WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stops = new StringBuilder(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "Travel")
            {
                string[] arguments = command.Split(":");
                switch (arguments[0])
                {
                    case "Add Stop":
                        int index = int.Parse(arguments[1]);
                        string newStop = arguments[2];
                        if (IsValidIndex(index, stops.Length - 1))
                        {
                            stops.Insert(index, newStop);
                        }
                        break;
                    case "Remove Stop":
                        int startIndex = int.Parse(arguments[1]);
                        int endIndex = int.Parse(arguments[2]);
                        if (IsValidIndex(startIndex, endIndex) && IsValidIndex(endIndex, stops.Length - 1))
                        {
                            stops.Remove(startIndex, endIndex - startIndex + 1);
                        }
                        break;
                    case "Switch":
                        string oldString = arguments[1];
                        string newString = arguments[2];
                        stops.Replace(oldString, newString);
                        break;
                        
                }

                Console.WriteLine(stops.ToString());
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops.ToString()}");
        }

        private static bool IsValidIndex(int index, int lastIndex)
        {
            return 0 <= index && index <= lastIndex;
        }
    }
}
