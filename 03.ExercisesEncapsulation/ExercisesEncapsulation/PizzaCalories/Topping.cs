using System;
using System.Collections.Generic;

public class Topping
{
    private const int TOPPING_MIN_WEIGHT = 1;
    private const int TOPPING_MAX_WEIGHT = 50;
    private const int TOPPING_DEFAULT_MULTIPLIER = 2;
    private const string TOPPING_TYPE_ERROR = "Cannot place {0} on top of your pizza.";
    private const string TOPPING_WEIGHT_ERROR = "{0} weight should be in the range [{1}..{2}].";

    private Dictionary<string, double> toppingTypes = new Dictionary<string, double>()
    {
        ["meat"] = 1.2,
        ["veggies"] = 0.8,
        ["cheese"] = 1.1,
        ["sauce"] = 0.9
    };

    private string type;
    private double weight;

    private double ToppingTypeMultiplier => toppingTypes[this.Type];

    public double Calories => TOPPING_DEFAULT_MULTIPLIER * this.Weight * ToppingTypeMultiplier;

    public Topping(string type, double weight)
    {
        this.Type = type;
        ValidateWeight(type, weight);
        this.Weight = weight;
    }

    public string Type
    {
        get { return type; }
        private set
        {
            if (!toppingTypes.ContainsKey(value.ToLower()))
            {
                throw new ArgumentException(string.Format(TOPPING_TYPE_ERROR, value));
            }
            type = value.ToLower();
        }
    }

    public double Weight
    {
        get { return this.weight; }
        private set
        {
            this.weight = value;
        }
    }

    private void ValidateWeight(string type, double weight)
    {
        if(weight < TOPPING_MIN_WEIGHT || weight > TOPPING_MAX_WEIGHT)
        {
            throw new ArgumentException(string.Format(TOPPING_WEIGHT_ERROR, type, TOPPING_MIN_WEIGHT, TOPPING_MAX_WEIGHT));
        }
    }

}