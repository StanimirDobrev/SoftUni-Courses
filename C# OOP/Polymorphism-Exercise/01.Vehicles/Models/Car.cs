using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using _01.Vehicles.Models.Interfaces;

namespace _01.Vehicles.Models
{
    public class Car : IVehicle
    {
        public Car(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption + 0.9;
        }

        public double FuelQuantity { get; private set; }
        public double FuelConsumption { get; }
        public string Drive(double distance)
        {
            var requiredFuel = distance * FuelConsumption;
            if (requiredFuel <= FuelQuantity)
            {
                FuelQuantity -= requiredFuel;
                return $"Car travelled {distance} km";
                
            }
            else
            {
                return $"Car needs refueling";
            }
        }

        public void Refuel(double fuelAmount)
        {
            FuelQuantity += fuelAmount;
        }

        public override string ToString() => $"{GetType().Name}: {this.FuelQuantity:f2}";
    }
}
