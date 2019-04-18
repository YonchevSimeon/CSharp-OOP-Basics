using System.Text;

public class Spy : Soldier, ISpy
{
    private int codeNumber;

    public Spy(string id, string firstName, string lastName, int codeNumber)
        :base(id, firstName, lastName)
    {
        this.CodeNumber = codeNumber;
    }

    public int CodeNumber
    {
        get { return this.codeNumber; }
        set { this.codeNumber = value; }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb
            .AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id}")
            .Append($"Code Number: {this.CodeNumber}");
        return sb.ToString();
    }
}
