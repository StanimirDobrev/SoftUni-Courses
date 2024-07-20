using System;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> packages = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> couriers = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            int totalweight = 0;
            while (packages.Count > 0 && couriers.Count > 0)
            {
                int package = packages.Pop();
                int courier = couriers.Dequeue();

                if (courier >= package)
                {
                    courier -= package * 2;
                    
                    if (courier > 0)
                    {
                        couriers.Enqueue(courier);
                    }
                    
                    totalweight += package;
                }
                else if (package > courier)
                {
                    package -= courier;
                    packages.Push(package);
                    totalweight += courier;
                }
            }

            Console.WriteLine($"Total weight: {totalweight} kg");

            if (packages.Count <= 0 && couriers.Count <= 0)
            {
                Console.WriteLine($"Congratulations, all packages were delivered successfully by the couriers today.");
            }
            else if (packages.Count > 0 && couriers.Count <= 0)
            {
                Console.WriteLine($"Unfortunately, there are no more available couriers to deliver the following packages: {string.Join(", ", packages)}");
            }
            else if (couriers.Count > 0 && packages.Count <= 0)
            {
                Console.WriteLine($"Couriers are still on duty: {string.Join(", ", couriers)} but there are no more packages to deliver.");
            }
        }
    }
}
