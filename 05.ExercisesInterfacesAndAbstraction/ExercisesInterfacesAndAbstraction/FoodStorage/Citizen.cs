﻿public class Citizen : IBuyer
{
    private string name;
    private int age;
    private string id;
    private string birthdate;
    private int food;

    public Citizen(string name, int age, string id, string birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthdate;
        this.Food = 0;
    }
    
    public string Name { get; set; }
    public int Age { get; set; }
    public string Id { get; set; }
    public string Birthdate { get; set; }
    public int Food { get; set; }

    public void BuyFood()
    {
        this.Food += 10;
    }
}
