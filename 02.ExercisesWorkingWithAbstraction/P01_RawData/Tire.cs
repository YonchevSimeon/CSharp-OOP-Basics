public class Tire
{
    private double tirePressure;
    private int tireAge;

    public double TirePressure
    {
        get { return this.tirePressure; }
        private set { this.tirePressure = value; }
    }

    public int TireAge
    {
        get { return this.tireAge; }
        private set { this.tireAge = value; }
    }

    public Tire(double tirePressure, int tireAge)
    {
        this.tirePressure = tirePressure;
        this.tireAge = tireAge;
    }
}