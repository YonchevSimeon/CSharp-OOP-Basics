public class SpecializedSoldier : Private, ISpecialisedSoldier
{
    private string corps;

    public SpecializedSoldier(string id, string firstName, string lastName, decimal salary, string corps)
        :base(id, firstName, lastName, salary)
    {
        this.Corps = corps;
    }

    public string Corps
    {
        get { return this.corps; }
        set { this.corps = value; }
    }
    
}
