﻿using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private string firstName;
    private string lastName;
    private int age;

    public string FirstName
    {
        get { return this.firstName; }
        private set { this.firstName = value; }
    }

    public int Age
    {
        get { return this.age; }
        private set { this.age = value; }
    }

    public Person(string firstName, string lastName, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }

    public override string ToString()
    {
        return $"{this.firstName} {this.lastName} is {this.age} years old.";
    }

}
