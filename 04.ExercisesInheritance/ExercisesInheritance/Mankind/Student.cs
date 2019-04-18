using System;
using System.Text;
using System.Text.RegularExpressions;

public class Student : Human
{
    private const string FACULTY_NUMBER_VALIDATION_PATTERN = @"^([a-zA-Z0-9]{5,10})$";

    private const int MIN_LENGTH_FACULTY_NUMBER = 5;
    private const int MAX_LENGTH_FACULTY_NUMBER = 10;

    private const string INVALID_FACULTY_NUMBER = "Invalid faculty number!";

    private string facultyNumber;

    public Student(string firstName, string lastName, string facultyNumber)
        : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public string FacultyNumber
    {
        get { return this.facultyNumber; }
        protected set
        {
            int valueLength = value.Length;
            if (!IsOnlyDigitsAndLetters(value))
            {
                throw new ArgumentException(INVALID_FACULTY_NUMBER);
            }

            this.facultyNumber = value;
        }
    }

    private bool IsOnlyDigitsAndLetters(string value)
    {
        Match match = Regex.Match(value, FACULTY_NUMBER_VALIDATION_PATTERN);
        if(match.Value == string.Empty)
        {
            return false;
        }
        return true;
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder
            .AppendLine($"First Name: {base.FirstName}")
            .AppendLine($"Last Name: {base.LastName}")
            .AppendLine($"Faculty number: {this.FacultyNumber}");

        return builder.ToString();
    }
}