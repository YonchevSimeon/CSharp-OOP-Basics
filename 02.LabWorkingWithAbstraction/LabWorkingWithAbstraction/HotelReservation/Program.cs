using System;

class Program
{
    static void Main(string[] args)
    {
        string[] inputArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        PriceCalculator priceCalculator = new PriceCalculator(inputArgs);
        Console.WriteLine(priceCalculator.Calculate());
    }
}
