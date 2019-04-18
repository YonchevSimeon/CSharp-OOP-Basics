using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private string carModel;
    private string carSpeed;

    public string CarModel
    {
        get { return this.carModel; }
        set { this.carModel = value; }
    }

    public string CarSpeed
    {
        get { return this.carSpeed; }
        set { this.carSpeed = value; }
    }

    public Car(string carModel, string carSpeed)
    {
        this.carModel = carModel;
        this.carSpeed = carSpeed;
    }

    public override string ToString()
    {
        return $"{this.carModel} {this.carSpeed}";
    }
}
