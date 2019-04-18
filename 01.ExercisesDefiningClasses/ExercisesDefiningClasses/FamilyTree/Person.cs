using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Person
{
    private string name;
    private string birthday;
    private List<Person> parents;
    private List<Person> children;

    public override string ToString()
    {
        return $"{this.name} {this.birthday}";
    }

    public Person(string name, string birthday)
    {
        this.name = name;
        this.birthday = birthday;
        this.parents = new List<Person>();
        this.children = new List<Person>();
    }
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public string Birthday
    {
        get { return this.birthday; }
        set { this.birthday = value; }
    }

    public List<Person> Parents
    {
        get { return this.parents; }
        set { this.parents = value; }
    }

    public List<Person> Children
    {
        get { return this.children; }
        set { this.children = value; }
    }
}

