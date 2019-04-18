public class Repair : IRepair
{
    private string partName;
    private int workedHours;

    public Repair(string partName, int workedHours)
    {
        this.PartName = partName;
        this.WorkedHours = workedHours;
    }

    public string PartName
    {
        get { return this.partName; } 
        set { this.partName = value; }
    }

    public int WorkedHours
    {
        get { return this.workedHours; }
        set { this.workedHours = value; }
    }

    public override string ToString()
    {
        return $"Part Name: {this.PartName} Hours Worked: {this.WorkedHours}";
    }
}
