public class GoldenEditionBook : Book
{
    private const decimal PERCANTAGE_INCREASE = 1.3m;

    public GoldenEditionBook(string author, string title, decimal price)
        : base(author, title, price) { }

    public override decimal Price
    {
        get
        {
            return base.Price * PERCANTAGE_INCREASE;
        }
    }
}
