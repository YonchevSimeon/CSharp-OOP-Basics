using System;
using System.Text;

public class Worker : Human
{
    private const decimal WORKDAYS = 5m;
    private const decimal MIN_SALARY = 10.01m;
    private const decimal MIN_WORKING_HOURS = 1m;
    private const decimal MAX_WORKING_HOURS = 12m;

    private const string WEEK_SALARY_PROP = "weekSalary";
    private const string WORKING_HOURS_PROP = "workHoursPerDay";

    private const string VALUE_MISMATCH_ERROR = "Expected value mismatch! Argument: {0}";

    private decimal weekSalary;
    private decimal workingHours;

    public Worker(string firstName, string lastName, decimal weekSalary, decimal workingHours)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkingHours = workingHours;
    }

    public decimal WeekSalary
    {
        get { return this.weekSalary; }
        protected set
        {
            if(value < MIN_SALARY)
            {
                throw new ArgumentException(string.Format(VALUE_MISMATCH_ERROR, WEEK_SALARY_PROP));
            }
            this.weekSalary = value;
        }
    }

    public decimal WorkingHours
    {
        get { return this.workingHours; }
        protected set
        {
            if(value < MIN_WORKING_HOURS || value > MAX_WORKING_HOURS)
            {
                throw new ArgumentException(string.Format(VALUE_MISMATCH_ERROR, WORKING_HOURS_PROP));
            }
            this.workingHours = value;
        }
    }

    private decimal SalaryPerHour()
    {
        return this.weekSalary / WORKDAYS / this.workingHours;
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder
            .AppendLine($"First Name: {base.FirstName}")
            .AppendLine($"Last Name: {base.LastName}")
            .AppendLine($"Week Salary: {this.WeekSalary:f2}")
            .AppendLine($"Hours per day: {this.WorkingHours:f2}")
            .AppendLine($"Salary per hour: {this.SalaryPerHour():f2}");
            
        return builder.ToString();
    }
}
