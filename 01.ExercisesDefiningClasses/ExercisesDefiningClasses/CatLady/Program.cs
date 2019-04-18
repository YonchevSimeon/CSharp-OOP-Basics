using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        List<Cat> cats = new List<Cat>();
        string input;
        while((input = Console.ReadLine()) != "End")
        {
            string[] inputTokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string breed = inputTokens[0];
            string name = inputTokens[1];
            Cat cat = new Cat(breed, name);
            switch (breed)
            {
                case "Siamese":
                    int earSize = int.Parse(inputTokens[2]);
                    cat = new Siamese(breed, name, earSize);
                    break;
                case "Cymric":
                    double furLength = double.Parse(inputTokens[2]);
                    cat = new Cymric(breed, name, furLength);
                    break;
                case "StreetExtraordinaire":
                    int decibelsOfMeows = int.Parse(inputTokens[2]);
                    cat = new StreetExtraordinaire(breed, name, decibelsOfMeows);
                    break;
                default: break;
            }
            cats.Add(cat);
        }
        string wantedCatName = Console.ReadLine();
        //if(cats.Any(c => c.Name == wantedCatName))
        //{
        Console.WriteLine(cats.Find(c => c.Name == wantedCatName));
        //}
    }
}
