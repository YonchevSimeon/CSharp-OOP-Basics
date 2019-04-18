namespace Animals
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string input;
            while((input = Console.ReadLine()) != "Beast!")
            {
                try
                {
                    Animal animal = GetAnimal(input);
                    Console.Write(animal);
                }
                catch(ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }

        private static Animal GetAnimal(string input)
        {
            string[] animalArgs = Console.ReadLine().Split();
            string name = animalArgs[0];
            int age = int.Parse(animalArgs[1]);

            switch (input)
            {
                case "Dog":
                    return new Dog(name, age, animalArgs[2]);
                case "Cat":
                    return new Cat(name, age, animalArgs[2]);
                case "Frog":
                    return new Frog(name, age, animalArgs[2]);
                case "Kitten":
                    return new Kitten(name, age);
                case "Tomcat":
                    return new Tomcat(name, age);
                default:
                    throw new ArgumentException("Invalid input!");
            }
        }
    }
}
