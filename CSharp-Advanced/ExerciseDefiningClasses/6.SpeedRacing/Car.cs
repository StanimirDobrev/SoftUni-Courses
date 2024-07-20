using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SpeedRacing
{
    internal class Car
    {
        public Car()
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.travelledDistance = travelledDistance;
        }

        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;
        public string Model
        {
            get => model;
            set => model = value;
        }

        public double FuelAmount
        {
            get => fuelAmount;
            set => fuelAmount = value;
        }

        public double FuelConsumptionPerKilometer
        {
            get => fuelConsumptionPerKilometer;
            set => fuelConsumptionPerKilometer = value;
        }

        public double TravelledDistance
        {
            get => travelledDistance;
            set => travelledDistance = value;
        }


        
        public void CanMoveThatDistance(int amountOfKm)
        {
            if (FuelConsumptionPerKilometer * amountOfKm <= FuelAmount)
            {
                FuelAmount -= FuelConsumptionPerKilometer * amountOfKm;
                TravelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
