using System;
using System.Collections.Generic;
using System.Text;

public class Siamese : Cat
{
    private int earSize;

    public int EarSize
    {
        get { return this.earSize; }
        set { this.earSize = value; }
    }

    public Siamese(string breed, string name, int earSize) : base(breed, name)
    {
        this.earSize = earSize;
    }

    public override string ToString()
    {
        return $"{base.ToString()} {this.earSize}";
    }
}
