using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();
        string input;
        while((input = Console.ReadLine()) != "End")
        {
            string[] inputTokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string name = inputTokens[0];
            string information = inputTokens[1];
            if(!people.Any(p => p.Name == name))
            {
                people.Add(new Person(name));
            }
            Person currentPerson = people.Find(p => p.Name == name);
            switch (information)
            {
                case "company":
                    string companyName = inputTokens[2];
                    string department = inputTokens[3];
                    decimal salary = decimal.Parse(inputTokens[4]);
                    currentPerson.Company = new Company(companyName, department, salary);
                    break;
                case "pokemon":
                    string pokemonName = inputTokens[2];
                    string pokemonType = inputTokens[3];
                    currentPerson.Pokemons.Add(new Pokemon(pokemonName, pokemonType));
                    break;
                case "parents":
                    string parentName = inputTokens[2];
                    string parentBirthday = inputTokens[3];
                    currentPerson.Parents.Add(new Parent(parentName, parentBirthday));
                    break;
                case "children":
                    string childName = inputTokens[2];
                    string childBirthday = inputTokens[3];
                    currentPerson.Children.Add(new Child(childName, childBirthday));
                    break;
                case "car":
                    string carModel = inputTokens[2];
                    string carSpeed = inputTokens[3];
                    currentPerson.Car = new Car(carModel, carSpeed);
                    break;
                default:break;
            }
        }
        string wantedPerson = Console.ReadLine();
        Person person = people.Find(p => p.Name == wantedPerson);
        if(person != null)
        {
            Console.Write(person);
        }

    }
}
