using System;
using System.Linq;
using WildFarm.Models;

namespace WildFarm
{
    abstract class Animal
    {
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = 0;
        }

        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }

        protected virtual Type[] PreferredFoods => new Type[] 
        { typeof(Vegetable), typeof(Fruit), typeof(Meat), typeof(Seeds) };

        protected virtual double WeightIncreaseMultiplier => 1;

        public void TryEatFood(Food food)
        {
            Type typeOfFood = food.GetType();

            if (!this.PreferredFoods.Contains(typeOfFood))
            {
                throw new InvalidOperationException($"{this.GetType().Name} does not eat {typeOfFood.Name}!");
            }
            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * this.WeightIncreaseMultiplier;
        }

        public abstract string MakeSound();

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, " + "{0}" + $"{this.Weight}, " + "{1}" + $"{this.FoodEaten}]";
        }
    }
}
