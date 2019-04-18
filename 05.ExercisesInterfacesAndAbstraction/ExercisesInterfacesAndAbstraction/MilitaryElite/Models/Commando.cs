using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Commando : SpecializedSoldier, ICommando
{
    private List<Mission> missions;

    public Commando(string id, string firstName, string lastName, decimal salary, string corps)
        :base(id, firstName, lastName, salary, corps)
    {
        this.Missions = new List<Mission>();
    }

    public List<Mission> Missions
    {
        get { return this.missions; }
        set { this.missions = value; }
    }

    public void CompleteMission(Mission mission)
    {
        mission.State = "Finished";
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb
            .AppendLine(base.ToString())
            .AppendLine($"Corps: {this.Corps}")
            .Append($"Missions:");
        if (this.Missions.Count > 0)
            sb
                .AppendLine()
                .Append(string.Join($"{Environment.NewLine}", this.Missions.Select(m => $"  {m}")));
        return sb.ToString();
    }
}
