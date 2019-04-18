using System;
using System.Text;

public class Tesla : ICar, IElectricCar
{
    private string model;
    private string color;
    private int battery;
    private string start;
    private string stop;
    public Tesla(string model, string color, int battery)
    {
        this.Model = model;
        this.Color = color;
        this.Battery = battery;
        this.Start = this.Start;
        this.Stop = this.Stop;
    }

    public string Model { get; set; }
    public string Color { get; set; }
    public int Battery { get; set; }

    public string Start
    {
        get { return this.start; }
        set { this.start = "Start Engine"; }
    }

    public string Stop
    {
        get { return this.stop; }
        set { this.stop = "Breaaak!"; }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.Color} {this.GetType().Name} {this.Model} with {this.Battery} Batteries");
        sb.AppendLine(this.Start);
        sb.Append(this.Stop);
        return sb.ToString();
    }
}
