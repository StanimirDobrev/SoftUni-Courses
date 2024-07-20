using System.Reflection.PortableExecutable;

namespace _6.SpeedRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            Car car = new Car();
            int cheks = 0;
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                //string model = command[0];
                //double FuelAmount = double.Parse(command[1]);
                //double fuelConsumptionPerKm = double.Parse(command[2]);

                foreach (var currCar in cars)
                {
                    if (currCar.Model == command[0])
                    {
                        cheks++;
                    }
                }

                if (cheks == 0)
                {
                    car.Model = command[0];
                    car.FuelAmount = double.Parse(command[1]);
                    car.FuelConsumptionPerKilometer = double.Parse(command[2]);
                    cars.Add(car);

                }

                cheks = 0;
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            { 
                string[] tokens = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                foreach (var c in cars)
                {
                    if (tokens[1] == car.Model)
                    {
                        car.CanMoveThatDistance(int.Parse(tokens[2]));
                    }
                }
            }

            foreach (var car1 in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
