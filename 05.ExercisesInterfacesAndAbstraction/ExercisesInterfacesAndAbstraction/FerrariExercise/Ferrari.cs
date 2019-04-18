using System;
using System.Text;

public class Ferrari : ICar
{
    private const string FERRARI_MODEL = "488-Spider";

    private string driver;
    private string model;

    public Ferrari(string driver)
    {
        this.Driver = driver;
        this.Model = FERRARI_MODEL;
    }

    public string Driver
    {
        get { return this.driver; }
        set { this.driver = value; }
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public string Brakes()
    {
        return "Brakes!";
    }

    public string GasPedal()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"{this.Model}/{this.Brakes()}/{this.GasPedal()}/{this.Driver}");
        return sb.ToString();
    }
}
