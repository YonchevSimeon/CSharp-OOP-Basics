using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int numberOfPersons = int.Parse(Console.ReadLine());
        Family family = new Family() { People = new List<Person>()};
        for (int curr = 0; curr < numberOfPersons; curr++)
        {
            string[] inputTokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string name = inputTokens[0];
            int age = int.Parse(inputTokens[1]);
            Person person = new Person() { Age = age, Name = name };
            family.AddMember(person);
        }
        Person oldestFamilyMember = family.GetOldestMember();
        Console.WriteLine($"{oldestFamilyMember.Name} {oldestFamilyMember.Age}");
    }
}
