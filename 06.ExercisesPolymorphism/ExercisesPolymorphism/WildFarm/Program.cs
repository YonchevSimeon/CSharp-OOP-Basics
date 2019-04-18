using System;
using System.Collections.Generic;
using WildFarm.Models;

namespace WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string input;
            while((input = Console.ReadLine()) != "End")
            {
                Animal animal = ParseAnimal(input);
                animals.Add(animal);

                string[] foodArgs = Console.ReadLine().Split();
                Food food = ParseFood(foodArgs);

                Console.WriteLine(animal.MakeSound());

                try
                {
                    animal.TryEatFood(food);
                }
                catch(InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static Food ParseFood(string[] foodArgs)
        {
            string type = foodArgs[0];
            int quantity = int.Parse(foodArgs[1]);

            switch (type)
            {
                case "Meat": return new Meat(quantity);
                case "Vegetable": return new Vegetable(quantity);
                case "Fruit": return new Fruit(quantity);
                case "Seeds": return new Seeds(quantity);

                default: throw new ArgumentException("Not a valid food type!");
            }
        }

        private static Animal ParseAnimal(string input)
        {
            string[] animalArgs = input.Split();

            string animalType = animalArgs[0];
            string name = animalArgs[1];
            double weight = double.Parse(animalArgs[2]);
            string dependantArg = animalArgs[3];
            

            switch (animalType)
            {
                case "Cat":
                    string catBreed = animalArgs[4];
                    return new Cat(name, weight, dependantArg, catBreed);
                case "Tiger":
                    string tigerBreed = animalArgs[4];
                    return new Tiger(name, weight, dependantArg, tigerBreed);
                case "Dog":
                    return new Dog(name, weight, dependantArg);
                case "Mouse":
                    return new Mouse(name, weight, dependantArg);
                case "Owl":
                    double owlWingSize = double.Parse(dependantArg);
                    return new Owl(name, weight, owlWingSize);
                case "Hen":
                    double henWingSize = double.Parse(dependantArg);
                    return new Hen(name, weight, henWingSize);
                default: throw new ArgumentException("Not a valid animal type!");
            }
        }
    }
}
