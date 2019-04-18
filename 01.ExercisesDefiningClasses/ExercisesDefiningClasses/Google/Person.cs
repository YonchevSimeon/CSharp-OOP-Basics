using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private string name;
    private Company company;
    private List<Pokemon> pokemons;
    private List<Parent> parents;
    private List<Child> children;
    private Car car;
    
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public Company Company
    {
        get { return this.company; }
        set { this.company = value; }
    }

    public List<Pokemon> Pokemons
    {
        get { return this.pokemons; }
        set { this.pokemons = value; }
    }

    public List<Parent> Parents
    {
        get { return this.parents; }
        set { this.parents = value; }
    }

    public List<Child> Children
    {
        get { return this.children; }
        set { this.children = value; }
    }

    public Car Car
    {
        get { return this.car; }
        set { this.car = value; }
    }

    public Person(string name)
    {
        this.name = name;
        this.company = null;
        this.pokemons = new List<Pokemon>();
        this.parents = new List<Parent>();
        this.children = new List<Child>();
        this.car = null;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine(this.name);
        stringBuilder.AppendLine("Company:");
        if(this.company != null)
        {
            stringBuilder.AppendLine(this.company.ToString());
        }
        stringBuilder.AppendLine("Car:");
        if(this.car != null)
        {
            stringBuilder.AppendLine(this.car.ToString());
        }
        stringBuilder.AppendLine("Pokemon:");
        this.pokemons.ForEach(p => stringBuilder.AppendLine(p.ToString()));
        stringBuilder.AppendLine("Parents:");
        this.parents.ForEach(p => stringBuilder.AppendLine(p.ToString()));
        stringBuilder.AppendLine("Children:");
        this.children.ForEach(c => stringBuilder.AppendLine(c.ToString()));
        return stringBuilder.ToString();
    }
}
