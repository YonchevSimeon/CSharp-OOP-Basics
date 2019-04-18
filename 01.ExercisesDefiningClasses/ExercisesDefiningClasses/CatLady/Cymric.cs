using System;
using System.Collections.Generic;
using System.Text;

public class Cymric : Cat
{
    private double furLength;

    public double FurLength
    {
        get { return this.furLength; }
        set { this.furLength = value; }
    }

    public Cymric(string breed, string name, double furLength) : base(breed, name)
    {
        this.furLength = furLength;
    }

    public override string ToString()
    {
        return $"{base.ToString()} {this.furLength:f2}";
    }
}
