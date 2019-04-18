using System;
using System.Collections.Generic;
using System.Linq;

public class Pizza
{
    private const int PIZZA_MIN_NAME_LENGHT = 1;
    private const int PIZZA_MAX_NAME_LENGHT = 15;
    private const int PIZZA_MIN_TOPPINGS = 0;
    private const int PIZZA_MAX_TOPPINGS = 10;
    private const string PIZZA_NAME_ERROR = "Pizza name should be between {0} and {1} symbols.";
    private const string PIZZA_TOPPING_ERROR = "Number of toppings should be in range [{0}..{1}].";
    private const string PIZZA_DOUGH_ERROR = "Dough already set!";


    private string name;
    private Dough Dough { get; set; }
    private List<Topping> Toppings { get; set; }

    public Pizza()
    {
        this.Toppings = new List<Topping>();
    }

    public Pizza(string name)
        :this()
    {
        this.Name = name;

    }
    
    private double ToppingsCalories
    {
        get
        {
            if(this.Toppings.Count == 0)
            {
                return 0;
            }
            return this.Toppings.Select(t => t.Calories).Sum();
        }
    }

    private double Calories => this.Dough.Calories + this.ToppingsCalories;

    private string Name
    {
        get { return this.name; }
        set
        { 
            if(string.IsNullOrEmpty(value) || value.Length > PIZZA_MAX_NAME_LENGHT)
            {
                throw new ArgumentException(string.Format(PIZZA_NAME_ERROR, PIZZA_MIN_NAME_LENGHT, PIZZA_MAX_NAME_LENGHT));
            }
            this.name = value;
        }
    }
    
    public void AddTopping(Topping topping)
    {
        this.Toppings.Add(topping);
        if(this.Toppings.Count > PIZZA_MAX_TOPPINGS)
        {
            throw new ArgumentException(string.Format(PIZZA_TOPPING_ERROR, PIZZA_MIN_TOPPINGS, PIZZA_MAX_TOPPINGS));
        }
    }

    public void SetDough(Dough dough)
    {
        if(this.Dough != null)
        {
            throw new InvalidOperationException(PIZZA_DOUGH_ERROR);
        }
        this.Dough = dough;
    }

    public override string ToString()
    {
        return $"{this.Name} - {this.Calories:f2} Calories.";
    }

}