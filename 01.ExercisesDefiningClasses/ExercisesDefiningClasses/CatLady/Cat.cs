using System;
using System.Collections.Generic;
using System.Text;

public class Cat
{
    private string breed;
    private string name;
    

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public string Breed
    {
        get { return this.breed; }
        set { this.breed = value; }
    }
    
    public Cat(string breed, string name)
    {
        this.breed = breed;
        this.name = name;
    }

    public override string ToString()
    {
        return $"{this.breed} {this.name}";
    }
}
