using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtention
{
    class Car : Vehicle
    {
        public Car(double fuelQuantity, double litersPerKm, double tankCapacity)
            : base(fuelQuantity, litersPerKm, tankCapacity) { this.LitersPerKm += 0.9; }

    }
}
