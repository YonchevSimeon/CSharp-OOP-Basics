using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Person> family = new List<Person>();
        List<string> storageForFamily = new List<string>();

        string mainPersonInfo = Console.ReadLine();

        string input;
        while((input = Console.ReadLine()) != "End")
        {
            string[] inputTokens = input.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
            if(inputTokens.Length == 1)
            {
                string[] inputParams = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string personName = $"{inputParams[0]} {inputParams[1]}";
                string personBirthday = inputParams[2];
                family.Add(new Person(personName, personBirthday));
            }
            else
            {
                storageForFamily.Add(input);
            }
        }

        foreach (string pair in storageForFamily)
        {
            string[] inputTokens = pair.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
            string parentInfo = inputTokens[0];
            string childInfo = inputTokens[1];

            Person parent;
            Person child;

            if (parentInfo.Contains('/') && childInfo.Contains('/'))
            {
                parent = family.First(p => p.Birthday == parentInfo);
                child = family.First(p => p.Birthday == childInfo);
            }
            else if (parentInfo.Contains('/') && !childInfo.Contains('/'))
            {
                parent = family.First(p => p.Birthday == parentInfo);
                child = family.First(p => p.Name == childInfo);
            }
            else if (!parentInfo.Contains('/') && childInfo.Contains('/'))
            {
                parent = family.First(p => p.Name == parentInfo);
                child = family.First(p => p.Birthday == childInfo);
            }
            else
            {
                parent = family.First(p => p.Name == parentInfo);
                child = family.First(p => p.Name == childInfo);
            }

            if (!parent.Children.Contains(child))
            {
                parent.Children.Add(child);
            }
            if (!child.Parents.Contains(parent))
            {
                child.Parents.Add(parent);
            }

            

        }
        Person mainPerson = family.FirstOrDefault(p => p.Name == mainPersonInfo || p.Birthday == mainPersonInfo);
        Console.WriteLine(mainPerson);
        Console.WriteLine("Parents:");
        foreach (Person parent in mainPerson.Parents)
        {
            Console.WriteLine(parent);
        }
        Console.WriteLine("Children:");
        foreach (Person child in mainPerson.Children)
        {
            Console.WriteLine(child);
        }
    }
}

