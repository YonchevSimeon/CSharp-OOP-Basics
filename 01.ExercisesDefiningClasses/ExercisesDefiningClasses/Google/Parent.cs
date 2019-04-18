using System;
using System.Collections.Generic;
using System.Text;

public class Parent
{
    private string parentName;
    private string parentBirthday;

    public string ParentName
    {
        get { return this.parentName; }
        set { this.parentName = value; }
    }

    public string ParentBirthday
    {
        get { return this.parentBirthday; }
        set { this.parentBirthday = value; }
    }

    public Parent(string parentName, string parentBirthday)
    {
        this.parentName = parentName;
        this.parentBirthday = parentBirthday;
    }

    public override string ToString()
    {
        return $"{this.parentName} {this.parentBirthday}";
    }
}
