using _01.Vehicles.Models;
using _01.Vehicles.Models.Interfaces;

namespace _01.Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] carInput = Console.ReadLine()
                .Split();
            string[] truckInput = Console.ReadLine()
                .Split();
            IVehicle car = new Car(double.Parse(carInput[1]), double.Parse(carInput[2]));
            IVehicle truck = new Truck(double.Parse(truckInput[1]), double.Parse(truckInput[2]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string vehicle = input[1];
                

                if (command == "Drive")
                {
                    double distance = double.Parse(input[2]);
                    if (vehicle == "Car")
                    {
                        Console.WriteLine(car.Drive(distance));
                    }
                    else if (vehicle == "Truck")
                    {
                        Console.WriteLine(truck.Drive(distance));
                    }
                }
                else if (command == "Refuel")
                {
                    double fuel = double.Parse(input[2]);
                    if (vehicle == "Car")
                    {
                        car.Refuel(fuel);
                    }
                    else if (vehicle == "Truck")
                    {
                        truck.Refuel(fuel);
                    }
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);

        }
    }
}
