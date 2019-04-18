using System;
using System.Collections.Generic;
using System.Text;

public class Company
{
    private string companyName;
    private string department;
    private decimal salary;

    public string CompanyName
    {
        get { return this.companyName; }
        set { this.companyName = value; }
    }

    public string Department
    {
        get { return this.department; }
        set { this.department = value; }
    }

    public decimal Salary
    {
        get { return this.salary; }
        set { this.salary = value; }
    }

    public Company(string companyName, string department, decimal salary)
    {
        this.companyName = companyName;
        this.department = department;
        this.salary = salary;
    }

    public override string ToString()
    {
        return $"{this.companyName} {this.department} {this.salary:f2}";
    }
}
