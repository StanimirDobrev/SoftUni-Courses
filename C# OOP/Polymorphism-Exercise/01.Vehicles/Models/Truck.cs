using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Vehicles.Models.Interfaces;

namespace _01.Vehicles.Models
{
    public class Truck : IVehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption * 1.6;
        }

        public double FuelQuantity { get; private set; }
        public double FuelConsumption { get; }
        public string Drive(double distance)
        {
            var requiredFuel = distance * FuelConsumption;
            if (requiredFuel >= FuelQuantity)
            {
                return $"Truck needs refueling";

            }
            FuelQuantity -= requiredFuel;
            return $"Truck travelled {distance} km";
        }

        public void Refuel(double fuelAmount )
        {
            double givenFuel = fuelAmount * 0.95;
            FuelQuantity += givenFuel;
        }

        public override string ToString() => $"{GetType().Name}: {FuelQuantity:f2}";
    }
}
