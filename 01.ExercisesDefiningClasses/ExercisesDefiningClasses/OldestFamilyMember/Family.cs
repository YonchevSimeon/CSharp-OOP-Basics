using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Family
{
    private List<Person> people;

    public List<Person> People
    {
        get { return this.people; }
        set { this.people = value; }
    }

    public void AddMember(Person member)
    {
        this.People.Add(member);
    }

    public Person GetOldestMember()
    {
        return this.People.OrderByDescending(p => p.Age).First();
    }
}


