using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class LeutenantGeneral : Private, ILeutenantGeneral
{
    private List<Private> privates;

    public LeutenantGeneral(string id, string firstName, string lastName, decimal salary)
        : base(id, firstName, lastName, salary)
    {
        this.privates = new List<Private>();
    }

    public List<Private> Privates
    {
        get { return this.privates; }
        set { this.privates = value; }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb
            .AppendLine(base.ToString())
            .Append("Privates:");
        if (this.Privates.Count > 0)
            sb
               .AppendLine()
               .Append(string.Join($"{Environment.NewLine}", this.Privates.Select(p => $"  {p}")));
        return sb.ToString();   
    }
}

