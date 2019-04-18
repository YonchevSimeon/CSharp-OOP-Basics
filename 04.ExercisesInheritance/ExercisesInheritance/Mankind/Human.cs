using System;
public class Human
{
    private const int FIRSTNAME_MIN_LENGTH = 4;
    private const int LASTNAME_MIN_LENGTH = 3;

    private const string FIRSTNAME_PROP = "firstName";
    private const string LASTNAME_PROP = "lastName";

    private const string NAME_UPPER_CASE_ERROR = "Expected upper case letter! Argument: {0}";
    private const string NAME_LENGTH_ERROR = "Expected length at least {0} symbols! Argument: {1}";

    private string firstName;
    private string lastName;

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string FirstName
    {
        get { return this.firstName; }
        protected set
        {
            if (value[0].ToString().ToLower() == value[0].ToString())
            {
                throw new ArgumentException(string.Format(NAME_UPPER_CASE_ERROR, FIRSTNAME_PROP));
            }
            else if (value.Length < FIRSTNAME_MIN_LENGTH)
            {
                throw new ArgumentException(string.Format(NAME_LENGTH_ERROR, FIRSTNAME_MIN_LENGTH, FIRSTNAME_PROP));
            }
            this.firstName = value;
        }
    }

    public string LastName
    {
        get { return this.lastName; }
        protected set
        {
            if (value[0].ToString().ToLower() == value[0].ToString())
            {
                throw new ArgumentException(string.Format(NAME_UPPER_CASE_ERROR, LASTNAME_PROP));
            }
            else if (value.Length < LASTNAME_MIN_LENGTH)
            {
                throw new ArgumentException(string.Format(NAME_LENGTH_ERROR, LASTNAME_MIN_LENGTH, LASTNAME_PROP));
            }
            this.lastName = value;
        }
    }
}
