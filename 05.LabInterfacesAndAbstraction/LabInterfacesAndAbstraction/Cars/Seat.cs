using System;
using System.Text;

public class Seat : ICar
{
    private string model;
    private string color;
    private string start;
    private string stop;

    public Seat(string model, string color)
    {
        this.Model = model;
        this.Color = color;
        this.Start = this.Start;
        this.Stop = this.Stop;
    }

    public string Model { get; set; }
    public string Color { get; set; }

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
        sb.AppendLine($"{this.Color} {this.GetType().Name} {this.Model}");
        sb.AppendLine(this.Start);
        sb.Append(this.Stop);
        return sb.ToString();
    }
}
