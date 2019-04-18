using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtention
{
    class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double litersPerKm, double tankCapacity)
            : base(fuelQuantity, litersPerKm, tankCapacity) { }

        public override void Drive(double distance)
        {
            double needed = distance * (this.LitersPerKm + 1.4);
            if(needed > this.FuelQuantity)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }
            this.FuelQuantity -= needed;
        }

        public void DriveEmpty(double distance)
        {
            base.Drive(distance);
        }
    }
}
