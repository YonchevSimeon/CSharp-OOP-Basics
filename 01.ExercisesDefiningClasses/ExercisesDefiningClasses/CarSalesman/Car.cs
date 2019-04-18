using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private string model;
    private Engine engine;
    private string weight;
    private string color;

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public Engine Engine
    {
        get { return this.engine; }
        set { this.engine = value; }
    }

    public string Weight
    {
        get { return this.weight; }
        set { this.weight = value; }
    }

    public string Color
    {
        get { return this.color; }
        set { this.color = value; }
    }

    public Car(string model, Engine engine)
    {
        this.model = model;
        this.engine = engine;
        this.weight = "n/a";
        this.color = "n/a";
    }

    public override string ToString()
    {
        return $"{this.Model}:{Environment.NewLine}" +
            $"  {this.Engine.Model}:{Environment.NewLine}" +
            $"    Power: {this.Engine.Power}{Environment.NewLine}" +
            $"    Displacement: {this.Engine.Displacement}{Environment.NewLine}" +
            $"    Efficiency: {this.Engine.Efficieny}{Environment.NewLine}" +
            $"  Weight: {this.Weight}{Environment.NewLine}" +
            $"  Color: {this.Color}";
    }
}
