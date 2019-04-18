using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtention
{
    class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double litersPerKm, double tankCapacity)
            : base(fuelQuantity, litersPerKm, tankCapacity) { this.LitersPerKm += 1.6; }

        public override void Refuel(double fuel)
        {
            if(fuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if((this.FuelQuantity + fuel) * 0.95 > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }

            this.FuelQuantity += fuel * 0.95;
        }
    }
}
