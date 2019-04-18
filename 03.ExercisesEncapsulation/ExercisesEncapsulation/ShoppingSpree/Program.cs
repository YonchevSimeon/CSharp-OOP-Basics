using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<Person> people = GetPeople();

            List<Product> products = GetProducts();

            DoOrders(people, products);

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }
        catch (ArgumentException argEx)
        {
            Console.WriteLine(argEx.Message);
        }
    }

    private static void DoOrders(List<Person> people, List<Product> products)
    {
        string order;
        while ((order = Console.ReadLine()) != "END")
        {
            string[] orderArgs = order.Split();
            string personName = orderArgs[0];
            string productName = orderArgs[1];
            Person person = people.First(p => p.Name == personName);
            Product product = products.First(p => p.Name == productName);
            string output = person.TryBuyProduct(product);
            Console.WriteLine(output);
        }
    }

    private static List<Product> GetProducts()
    {
        List<Product> products = new List<Product>();
        string[] inputLines = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
        foreach (string input in inputLines)
        {
            string[] productArgs = input.Split('=');
            string name = productArgs[0];
            decimal cost = decimal.Parse(productArgs[1]);
            Product product = new Product(name, cost);
            products.Add(product);
        }
        return products;
    }

    private static List<Person> GetPeople()
    {
        List<Person> people = new List<Person>();
        string[] inputLines = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
        foreach (string input in inputLines)
        {
            string[] personArgs = input.Split('=');
            string name = personArgs[0];
            decimal money = decimal.Parse(personArgs[1]);
            Person person = new Person(name, money);
            people.Add(person);
        }
        return people;
    }
}
