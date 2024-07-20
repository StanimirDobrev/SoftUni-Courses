namespace Problem3_NeedForSpeedIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|");
                string model = input[0];
                int mileage = int.Parse(input[1]);
                int fuel = int.Parse(input[2]);
                cars.Add(new Car(model, mileage, fuel));
            }

            string argument;
            while ((argument = Console.ReadLine()) != "Stop")
            {
                string[] arguments = argument.Split(" : ");
                string command = arguments[0];
                string currentCar = arguments[1];
                Car car = cars.Find(x => x.Model == currentCar);

                switch (command)
                {
                    case "Drive":
                        int distance = int.Parse(arguments[2]);
                        int neededFuel = int.Parse(arguments[3]);

                        if (neededFuel > car.Fuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                            continue;
                        }
                        else
                        {
                            car.Mileage += distance;
                            car.Fuel -= neededFuel;
                            Console.WriteLine($"{car.Model} driven for {distance} kilometers. {neededFuel} liters of fuel consumed.");
                        }

                        if (car.Mileage > 100_000)
                        {
                            cars.Remove(car);
                            Console.WriteLine($"Time to sell the {car.Model}!");
                        }
                        break;
                    case "Refuel":
                        int fuel = int.Parse(arguments[2]);
                        if (car.Fuel + fuel < 75)
                        {
                            car.Fuel += fuel;
                        }
                        else if (car.Fuel + fuel >= 75)
                        {
                            fuel = 75 - car.Fuel;
                            car.Fuel += fuel;
                        }
                        Console.WriteLine($"{car.Model} refueled with {fuel} liters");
                        break;
                    case "Revert":
                        int kilometresToRevert = int.Parse(arguments[2]);
                        if (car.Mileage - kilometresToRevert > 10_000)
                        {
                            car.Mileage -= kilometresToRevert;
                            Console.WriteLine($"{car.Model} mileage decreased by {kilometresToRevert} kilometers");
                        }
                        else
                        {
                            car.Mileage = 10_000;
                        }
                        break;
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }
    }

    class Car
    {
        public Car(string model, int mileage, int fuel)
        {
            Model = model;
            Mileage = mileage;
            Fuel = fuel;
        }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
}
