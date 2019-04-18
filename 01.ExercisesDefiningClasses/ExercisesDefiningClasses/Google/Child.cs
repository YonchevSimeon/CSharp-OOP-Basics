using System;
using System.Collections.Generic;
using System.Text;

public class Child
{
    private string childName;
    private string childBirthday;

    public string ChildName
    {
        get { return this.childName; }
        set { this.childName = value; }
    }

    public string ChildBirthday
    {
        get { return this.childBirthday; }
        set { this.childBirthday = value; }
    }

    public Child(string childName, string childBirthday)
    {
        this.childName = childName;
        this.childBirthday = childBirthday;
    }

    public override string ToString()
    {
        return $"{this.childName} {this.childBirthday}";
    }
}
