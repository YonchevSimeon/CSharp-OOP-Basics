using System;
using System.Collections.Generic;
using System.Text;

public class Engine
{
    private string model;
    private string power;
    private string displacement;
    private string efficiency;

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public string Power
    {
        get { return this.power; }
        set { this.power = value; }
    }

    public string Displacement
    {
        get { return this.displacement; }
        set { this.displacement = value; }
    }

    public string Efficieny
    {
        get { return this.efficiency; }
        set { this.efficiency = value; }
    }

    public Engine(string model, string power)
    {
        this.model = model;
        this.power = power;
        this.displacement = "n/a";
        this.efficiency = "n/a";
    }
    
}
