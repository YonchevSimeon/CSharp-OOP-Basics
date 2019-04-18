using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtention
{
    abstract class Vehicle
    {
        private double fuelQuantity;
        private double litersPerKm;
        private double tankCapacity;

        public Vehicle(double fuelQuantity, double litersPerKm, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.LitersPerKm = litersPerKm;
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            protected set
            {
                if(value <= 0)
                    throw new ArgumentException("Fuel must be a positive number");
                if (value > this.TankCapacity)
                    this.fuelQuantity = 0;
                else
                    this.fuelQuantity = value;
            }
        }

        public virtual double LitersPerKm
        {
            get { return this.litersPerKm; }
            set { this.litersPerKm = value; }
        }

        public double TankCapacity
        {
            get { return this.tankCapacity; }
            set { this.tankCapacity = value; }
        }

        public virtual void Drive(double distance)
        {
            double needed = distance * (this.LitersPerKm);
            if(needed > this.FuelQuantity)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }
            this.FuelQuantity -= needed;
        }

        public virtual void Refuel(double fuel)
        {
            if(fuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if(this.FuelQuantity + fuel > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }
            else
            {
                this.FuelQuantity += fuel;
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
