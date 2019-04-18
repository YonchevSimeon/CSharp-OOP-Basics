using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Engineer : SpecializedSoldier, IEngineer
{
    private List<Repair> repairs;

    public Engineer(string id, string firstName, string lastName, decimal salary, string corps)
        :base(id, firstName, lastName, salary, corps)
    {
        this.Repairs = new List<Repair>();
    }

    public List<Repair> Repairs
    {
        get { return this.repairs; }
        set { this.repairs = value; }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb
            .AppendLine(base.ToString())
            .AppendLine($"Corps: {this.Corps}")
            .Append("Repairs:");
        if(this.Repairs.Count > 0)
            sb
                .AppendLine()
                .Append(string.Join($"{Environment.NewLine}", this.Repairs.Select(r => $"  {r}")));
        return sb.ToString();
    }
}
