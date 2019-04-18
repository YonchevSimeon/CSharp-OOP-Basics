using System;
using System.Collections.Generic;

public class Dough
{
    private const int DOUGH_MIN_WEIGHT = 1;
    private const int DOUGH_MAX_WEIGHT = 200;
    private const int DEFAULT_MULTIPLIER = 2;
    private const string DOUGH_WEIGHT_ERROR = "Dough weight should be in the range [{0}..{1}].";
    private const string DOUGH_TYPE_ERROR = "Invalid type of dough.";

    private Dictionary<string, double> flourTypes = new Dictionary<string, double>()
    {
        ["white"] = 1.5,
        ["wholegrain"] = 1.0
    };

    private Dictionary<string, double> bakingTechniques = new Dictionary<string, double>()
    {
        ["crispy"] = 0.9,
        ["chewy"] = 1.1,
        ["homemade"] = 1.0
    };

    private double weight;
    private string flourType;
    private string bakingTechnique;

    private double FlourMultiplier => flourTypes[this.FlourType];
    private double BakingTechniqueMultiplier => bakingTechniques[this.BakingTechnique];

    public double Calories => DEFAULT_MULTIPLIER * this.Weight * FlourMultiplier * BakingTechniqueMultiplier;

    public Dough(double weight, string flourType, string bakingTechnique)
    {
        this.Weight = weight;
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
    }

    public double Weight
    {
        get { return this.weight; }
        private set
        {
            if(value < DOUGH_MIN_WEIGHT || value > DOUGH_MAX_WEIGHT)
            {
                throw new ArgumentException(string.Format(DOUGH_WEIGHT_ERROR, DOUGH_MIN_WEIGHT, DOUGH_MAX_WEIGHT));
            }
            this.weight = value;
        }
    }

    public string FlourType
    {
        get { return this.flourType; }
        private set
        {
            ValidateDoughTypes(value, flourTypes);
            this.flourType = value.ToLower();
        }
    }

    public string BakingTechnique
    {
        get { return this.bakingTechnique; }
        private set
        {
            ValidateDoughTypes(value, bakingTechniques);
            this.bakingTechnique = value.ToLower();
        }
    }

    private static void ValidateDoughTypes(string type, Dictionary<string, double> dict)
    {
        if (!dict.ContainsKey(type.ToLower()))
        {
            throw new ArgumentException(DOUGH_TYPE_ERROR);
        }
    }
}