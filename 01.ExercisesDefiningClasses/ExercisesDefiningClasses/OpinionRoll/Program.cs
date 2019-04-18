using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        List<Person> persons = new List<Person>();
        int numberOfPersons = int.Parse(Console.ReadLine());
        for (int curr = 0; curr < numberOfPersons; curr++)
        {
            string[] inputTokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string name = inputTokens[0];
            int age = int.Parse(inputTokens[1]);
            Person currPerson = new Person() { Age = age, Name = name };
            persons.Add(currPerson);
        }
        foreach (Person person in persons.Where(p => p.Age > 30).OrderBy(p => p.Name))
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }
}