using System;

public class Person
{
    protected const int AGE_MIN_VALUE = 0;
    protected const string PERSON_AGE_ERROR = "Age must be positive!";
    protected const string PERSON_OVERRIRE_TO_STRING = "Name: {0}, Age: {1}";

    private string name;
    private int age;

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public virtual string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public virtual int Age
    {
        get { return this.age; }
        set
        {
            if(value < AGE_MIN_VALUE)
            {
                throw new ArgumentException(PERSON_AGE_ERROR);
            }
            this.age = value;
        }
    }

    public override string ToString()
    {
        return string.Format(PERSON_OVERRIRE_TO_STRING, this.Name, this.Age);
    }
}
