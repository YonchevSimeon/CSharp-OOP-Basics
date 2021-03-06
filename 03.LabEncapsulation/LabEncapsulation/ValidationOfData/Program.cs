﻿using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());
        List<Person> persons = new List<Person>();
        for (int i = 0; i < lines; i++)
        {
            string[] cmdArgs = Console.ReadLine().Split();
            try
            {
                Person person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
                persons.Add(person);
            }
            catch(ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
        }
        decimal bonus = decimal.Parse(Console.ReadLine());
        persons.ForEach(p => p.IncreaseSalary(bonus));
        persons.ForEach(p => Console.WriteLine(p.ToString()));
    }
}
