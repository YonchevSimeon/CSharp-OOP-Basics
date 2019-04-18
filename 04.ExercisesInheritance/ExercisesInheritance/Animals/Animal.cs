using System;
using System.Text;

public class Animal : ISoundProducable
{
    private const string INVALID_INPUT = "Invalid input!";

    private string name;
    private int age;
    private string gender;

    protected Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    protected string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(INVALID_INPUT);
            }
            this.name = value;
        }
    }

    protected int Age
    {
        get { return this.age; }
        set
        {
            if(value < 0)
            {
                throw new ArgumentException(INVALID_INPUT);
            }
            this.age = value;
        }
    }

    protected string Gender
    {
        get { return this.gender; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(INVALID_INPUT);
            }
            this.gender = value;
        }
    }

    public virtual string ProduceSound()
    {
        return "Empty Sound!";
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder
            .AppendLine(this.GetType().Name)
            .AppendLine($"{this.Name} {this.Age} {this.Gender}")
            .AppendLine(this.ProduceSound());
        return builder.ToString();
    }
}
