using System;

public class PriceCalculator
{
    private decimal pricePerDay;
    private int numberOfDays;
    private Seasons season;
    private Discounts discountType;

    public PriceCalculator(string[] args)
    {
        pricePerDay = decimal.Parse(args[0]);
        numberOfDays = int.Parse(args[1]);
        season = Enum.Parse<Seasons>(args[2]);
        discountType = Discounts.None;
        if(args.Length > 3)
            discountType = Enum.Parse<Discounts>(args[3]);
    }

    public string Calculate()
    {
        decimal totalPrice = this.pricePerDay * this.numberOfDays * (int)this.season;
        decimal discountPercentage = ((decimal) 100 - (int)this.discountType) / 100;
        totalPrice = totalPrice * discountPercentage;
        return totalPrice.ToString("f2");
    }
}
