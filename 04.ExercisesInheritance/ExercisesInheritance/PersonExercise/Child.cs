using System;

public class Child : Person
{
    private const int CHILD_MAX_AGE = 15;
    private const int CHILD_NAME_MIN_LENGTH = 3;
    private const string CHILD_AGE_ERROR = "Child's age must be less than {0}!";
    private const string CHILD_NAME_ERROR = "Name's length should not be less than {0} symbols!";

    public Child(string name, int age)
        : base(name, age) { }

    public override string Name
    {
        get { return base.Name; }
        set
        {
            if(value.Length < CHILD_NAME_MIN_LENGTH)
            {
                throw new ArgumentException(string.Format(CHILD_NAME_ERROR, CHILD_NAME_MIN_LENGTH));
            }
            base.Name = value;
        }
    }

    public override int Age
    {
        get { return base.Age; }
        set
        {
            if(value > CHILD_MAX_AGE)
            {
                throw new ArgumentException(string.Format(CHILD_AGE_ERROR, CHILD_MAX_AGE));
            }
            base.Age = value;
        }
    }
}
