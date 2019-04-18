using System;
using System.Collections.Generic;

public class Gandalf
{
    private Dictionary<string, int> foods = new Dictionary<string, int>()
    {
        ["cram"] = 2,
        ["lembas"] = 3,
        ["apple"] = 1,
        ["melon"] = 1,
        ["honeycake"] = 5,
        ["mushrooms"] = -10
    };

    private int happiness;

    public Gandalf()
    {
        this.happiness = 0;
    }

    public void EatFood(string foodName)
    {
        if (foods.ContainsKey(foodName))
            happiness += foods[foodName];
        else
            happiness--;
    }

    private string GetGandalfMood()
    {
        if (this.happiness < -5)
            return "Angry";
        else if (this.happiness >= -5 && this.happiness <= 0)
            return "Sad";
        else if (this.happiness > 0 && this.happiness <= 15)
            return "Happy";
        else
            return "JavaScript";
    }

    public override string ToString()
    {
        return $"{this.happiness}{Environment.NewLine}{GetGandalfMood()}";
    }
}
