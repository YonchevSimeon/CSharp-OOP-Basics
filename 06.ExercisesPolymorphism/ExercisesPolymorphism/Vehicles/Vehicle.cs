using System;

public class Vehicle : IVehicle
{
    private double fuelQuantity;
    private double litersPerKm;

    public  Vehicle(double fuelQuantity, double litersPerKm)
    {
        this.FuelQuantity = fuelQuantity;
        this.LitersPerKm = litersPerKm;
    }

    public double FuelQuantity
    {
        get { return this.fuelQuantity; }
        protected set { this.fuelQuantity = value; }
    }

    public virtual double LitersPerKm
    {
        get { return this.litersPerKm; }
        protected set { this.litersPerKm = value; }
    }

    public virtual void Drive(double distance)
    {
        if(this.FuelQuantity / this.LitersPerKm < distance)
        {
            throw new ArgumentException($"{this.GetType().Name} needs refueling");
        }
        this.FuelQuantity -= distance * this.LitersPerKm;

    }

    public virtual void Refuel(double fuel)
    {
        this.FuelQuantity += fuel;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
    }
}
