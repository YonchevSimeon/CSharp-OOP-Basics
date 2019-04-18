namespace ExplicitInterfaces
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string input;
            while((input = Console.ReadLine()) != "End")
            {
                string[] personArgs = input.Split();

                string name = personArgs[0];
                int age = int.Parse(personArgs[2]);
                string country = personArgs[1];

                Person person = new Person(name, age, country);

                Console.WriteLine(((IPerson)person).GetName());
                Console.WriteLine(((IResident)person).GetName());
            }
        }
    }
}
