using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    private string name;
    private decimal money;
    private List<Product> bag;

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"Name cannot be empty");
            }
            this.name = value;
        }
    }

    public decimal Money
    {
        get { return this.money; }
        private set
        {
            if(value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            this.money = value;
        }
    }

    public string TryBuyProduct(Product product)
    {
        if (product.Cost > this.Money)
        {
            return $"{this.Name} can't afford {product.Name}";
        }
        this.Money -= product.Cost;
        bag.Add(product);
        return $"{this.Name} bought {product.Name}";
    }

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.bag = new List<Product>();
    }

    public override string ToString()
    {
        string productsOutput = this.bag.Count > 0 ?
            string.Join(", ", this.bag.Select(p => p.Name).ToList()) : "Nothing bought";
        string result = $"{this.Name} - {productsOutput}";
        return result;
    }
}