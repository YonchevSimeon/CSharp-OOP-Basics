using System.Text;

public class Engine
{
    private const string offset = "  ";

    private string model;
    private int power;
    private int displacement;
    private string efficiency;

    public string Model
    {
        get { return this.model; }
        private set { this.model = value; }
    }

    public int Power
    {
        get { return this.power; }
        private set { this.power = value; }
    }

    public int Displacement
    {
        get { return this.displacement; }
        private set { this.displacement = value; }
    }

    public string Efficiency
    {
        get { return this.efficiency; }
        private set { this.efficiency = value; }
    }

    public Engine(string model, int power)
    {
        this.model = model;
        this.power = power;
        this.displacement = -1;
        this.efficiency = "n/a";
    }

    public Engine(string model, int power, int displacement)
        :this(model, power)
    {
        this.displacement = displacement;
    }

    public Engine(string model, int power, string efficiency)
        :this(model, power)
    {
        this.efficiency = efficiency;
    }

    public Engine(string model, int power, int displacement, string efficiency)
        : this(model, power)
    {
        this.displacement = displacement;
        this.efficiency = efficiency;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendFormat("{0}{1}:\n", offset, this.model);
        sb.AppendFormat("{0}{0}Power: {1}\n", offset, this.power);
        sb.AppendFormat("{0}{0}Displacement: {1}\n", offset, this.displacement == -1 ? "n/a" : this.displacement.ToString());
        sb.AppendFormat("{0}{0}Efficiency: {1}\n", offset, this.efficiency);

        return sb.ToString();
    }
}