using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private int age;
    private string name;

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public Person()
    {
        this.Age = 1;
        this.Name = "No name";
    }

    public Person(int age)
    {
        this.Age = age;
        this.Name = "No name";
    }

    public Person(int age, string name)
    {
        this.Age = age;
        this.Name = name;
    }
}

