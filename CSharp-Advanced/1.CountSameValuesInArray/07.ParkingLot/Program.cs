internal class Program
{
    static void Main(string[] args)
    {
        HashSet<string> cars = new HashSet<string>();

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] tokens = command.Split(", ");

            string direction = tokens[0];
            string licensePlate = tokens[1];

            switch (direction)
            {
                case "IN":
                    cars.Add(licensePlate);
                    break;
                case "OUT":
                    cars.Remove(licensePlate);
                    break;
            }
        }
        if (cars.Count == 0)
        {
            Console.WriteLine("Parking Lot is Empty");
            return;
        }
        Console.WriteLine(string.Join(Environment.NewLine, cars));
    }
}