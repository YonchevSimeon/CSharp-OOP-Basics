public interface IVehicle
{
    double FuelQuantity { get; }
    double LitersPerKm { get; }
    void Drive(double distance);
    void Refuel(double fuel);
}
