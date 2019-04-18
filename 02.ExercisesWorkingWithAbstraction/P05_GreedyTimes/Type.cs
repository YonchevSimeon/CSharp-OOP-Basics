public class Type
{
    private string name;
    private long quantity;

    public string Name
    {
        get { return this.name; }
        private set { this.name = value; }
    }

    public long Quantity
    {
        get { return this.quantity; }
        private set { this.quantity = value; }
    }

    public Type(string name)
    {
        this.name = name;
        this.quantity = 0L;
    }

    public void AddQuantity(long quantity)
    {
        this.quantity += quantity;
    }
}
