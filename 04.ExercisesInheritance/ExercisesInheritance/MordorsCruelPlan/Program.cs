namespace MordorsCruelPlan
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Gandalf gandalf = new Gandalf();
            string[] foodsToEat = Console.ReadLine().ToLower().Split(' ');
            foreach (string food in foodsToEat)
            {
                gandalf.EatFood(food);
            }
            Console.WriteLine(gandalf);
        }
    }
}
