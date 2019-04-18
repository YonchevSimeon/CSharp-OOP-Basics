public class Truck : Vehicle
{
    public Truck(double fuelQuantiy, double litersPerKm)
        :base(fuelQuantiy, litersPerKm) { }

    public override double LitersPerKm
    {
        get { return base.LitersPerKm + 1.6; }
    }

    public override void Refuel(double fuel)
    {
        this.FuelQuantity += fuel * 0.95;
    }
}
