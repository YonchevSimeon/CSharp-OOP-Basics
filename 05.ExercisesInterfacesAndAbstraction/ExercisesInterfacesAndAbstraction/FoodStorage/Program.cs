namespace FoodStorage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<IBuyer> buyers = GetBuyers();
            BuyFoods(buyers);
            Console.WriteLine(buyers.Select(b => b.Food).Sum());
        }

        private static void BuyFoods(List<IBuyer> buyers)
        {
            string input;
            while((input = Console.ReadLine()) != "End")
            {
                IBuyer buyer = buyers.FirstOrDefault(b => b.Name == input);
                if(buyer != null)
                {
                    buyer.BuyFood();
                }
            }
        }

        private static List<IBuyer> GetBuyers()
        {
            List<IBuyer> buyers = new List<IBuyer>();
            int numberOfInputs = int.Parse(Console.ReadLine());
            for (int index = 0; index < numberOfInputs; index++)
            {
                string[] inputTokens = Console.ReadLine().Split();

                string name = inputTokens[0];
                int age = int.Parse(inputTokens[1]);

                if(inputTokens.Length == 4)
                {
                    string id = inputTokens[2];
                    string birthdate = inputTokens[3];
                    buyers.Add(new Citizen(name, age, id, birthdate));
                }
                else
                {
                    string group = inputTokens[2];
                    buyers.Add(new Rebel(name, age, group));
                }
            }
            return buyers;
        }
    }
}
