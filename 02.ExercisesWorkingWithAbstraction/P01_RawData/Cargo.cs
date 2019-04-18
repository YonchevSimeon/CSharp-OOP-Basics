public class Cargo
{
    private int cargoWeight;
    private string cargoType;

    public int CargoWeight
    {
        get { return this.cargoWeight; }
        private set { this.cargoWeight = value; }
    }

    public string CargoType
    {
        get { return this.cargoType; }
        private set { this.cargoType = value; }
    }

    public Cargo(int cargoWeight, string cargoType)
    {
        this.cargoWeight = cargoWeight;
        this.cargoType = cargoType;
    }
}