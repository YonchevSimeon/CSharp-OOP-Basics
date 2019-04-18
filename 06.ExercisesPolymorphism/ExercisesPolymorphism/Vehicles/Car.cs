public class Car : Vehicle
{
    public Car(double fuelQuantity, double litersPerKm)
        :base(fuelQuantity, litersPerKm) { }

    public override double LitersPerKm
    {
        get { return base.LitersPerKm + 0.9; }
    }
}
