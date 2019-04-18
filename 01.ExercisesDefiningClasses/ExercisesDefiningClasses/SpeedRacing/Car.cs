using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private string carModel;
    private double fuelAmount;
    private double fuelConsumptionPerKilometer;
    private int distanceTraveled;

    public Car(string carModel, double fuelAmount, double fuelConsumptionPerKilometer)
    {
        this.carModel = carModel;
        this.fuelAmount = fuelAmount;
        this.fuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        this.distanceTraveled = 0;
    }

    public string CarModel
    {
        get { return this.carModel; }
        set { this.carModel = value; }
    }

    public double FuelAmount
    {
        get { return this.fuelAmount; }
        set { this.fuelAmount = value; }
    }

    public int DistanceTraveled
    {
        get { return this.distanceTraveled; }
        set { this.distanceTraveled = value; }
    }

    public void DriveTheCarWith(int kilometers)
    {
        if(kilometers <= this.fuelAmount / this.fuelConsumptionPerKilometer)
        {
            this.distanceTraveled += kilometers;
            this.fuelAmount -= this.fuelConsumptionPerKilometer * kilometers;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }

    public override string ToString()
    {
        return $"{this.carModel} {this.fuelAmount:f2} {this.distanceTraveled}";
    }
}
