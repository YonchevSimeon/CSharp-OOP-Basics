public class Person : IPerson, IResident
{
    private string name;
    private int age;
    private string country;

    public Person(string name, int age, string country)
    {
        this.Name = name;
        this.Age = age;
        this.Country = country;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public string Country { get; set; }

    string IResident.GetName()
    {
        return $"Mr/Ms/Mrs {this.Name}";
    }

    string IPerson.GetName()
    {
        return this.Name;
    }
}
