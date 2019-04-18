﻿using System.Text;
public class Car
{
    private const string offset = "  ";

    private string model;
    private Engine engine;
    private int weight;
    private string color;

    public string Model
    {
        get { return this.model; }
        private set { this.model = value; }
    }

    public Engine Engine
    {
        get { return this.engine; }
        private set { this.engine = value; }
    }

    public int Weight
    {
        get { return this.weight; }
        private set { this.weight = value; }
    }

    public string Color
    {
        get { return this.color; }
        private set { this.color = value; }
    }

    public Car(string model, Engine engine)
    {
        this.model = model;
        this.engine = engine;
        this.weight = -1;
        this.color = "n/a";
    }

    public Car(string model, Engine engine, int weight)
        :this(model, engine)
    {
        this.weight = weight;
    }

    public Car(string model, Engine engine, string color)
        :this(model, engine)
    {
        this.color = color;
    }

    public Car(string model, Engine engine, int weight, string color)
        :this(model, engine)
    {
        this.weight = weight;
        this.color = color;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendFormat("{0}:\n", this.model);
        sb.Append(this.engine.ToString());
        sb.AppendFormat("{0}Weight: {1}\n", offset, this.weight == -1 ? "n/a" : this.weight.ToString());
        sb.AppendFormat("{0}Color: {1}", offset, this.color);

        return sb.ToString();
    }
}