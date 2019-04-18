namespace PizzaCalories
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pizza pizza = GetPizza();

                Dough dough = GetDough();

                pizza.SetDough(dough);

                AddToppings(pizza);

                Console.WriteLine(pizza);
            }
            catch(ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
        }

        private static Dough GetDough()
        {
            string[] doughArgs = Console.ReadLine().Split();

            string flourType = doughArgs[1];
            string bakingTechnique = doughArgs[2];
            double doughWeight = double.Parse(doughArgs[3]);

            Dough dough = new Dough(doughWeight, flourType, bakingTechnique);

            return dough;
        }

        private static Pizza GetPizza()
        {
            string pizzaName = Console.ReadLine().Split()[1];
            Pizza pizza = new Pizza(pizzaName);
            return pizza;
        }

        private static void AddToppings(Pizza pizza)
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] toppingArguments = input.Split();

                string toppingType = toppingArguments[1];
                double toppingWeight = double.Parse(toppingArguments[2]);

                Topping topping = new Topping(toppingType, toppingWeight);

                pizza.AddTopping(topping);
            }
        }
    }
}
