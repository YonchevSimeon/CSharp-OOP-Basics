using System;
using System.Collections.Generic;
using System.Text;

public class StreetExtraordinaire : Cat
{
    private int decibelsOfMeows;

    public int DecibelsOfMeows
    {
        get { return this.decibelsOfMeows; }
        set { this.decibelsOfMeows = value; }
    }

    public StreetExtraordinaire(string breed, string name, int decibelsOfMeows) : base(breed, name)
    {
        this.decibelsOfMeows = decibelsOfMeows;
    }

    public override string ToString()
    {
        return $"{base.ToString()} {this.decibelsOfMeows}";
    }
}