using System;
using System.Collections.Generic;
using System.Linq;

class GreedyTimes
{
    private static long capacityOfBag;
    static void Main(string[] args)
    {
        List<Type> gold = new List<Type>();
        List<Type> gems = new List<Type>();
        List<Type> cash = new List<Type>();

        capacityOfBag = long.Parse(Console.ReadLine());

        string[] inputTokens = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        FillTheBag(inputTokens, gold, gems, cash);

        PrintTheBag(gold, gems, cash);
    }

    private static void PrintTheBag(List<Type> gold, List<Type> gems, List<Type> cash)
    {
        if(gold.Count > 0)
        {
            Console.WriteLine($"<Gold> ${gold[0].Quantity}");
            Console.WriteLine($"##Gold - {gold[0].Quantity}");
            if(gems.Count > 0)
            {
                Console.WriteLine($"<Gem> ${gems.Sum(g => g.Quantity)}");
                gems.OrderByDescending(g => g.Name)
                    .ThenBy(g => g.Quantity)
                    .ToList()
                    .ForEach(g => Console.WriteLine($"##{g.Name} - {g.Quantity}"));
            }
            if(cash.Count > 0)
            {
                Console.WriteLine($"<Cash> ${cash.Sum(c => c.Quantity)}");
                cash.OrderByDescending(c => c.Name)
                    .ThenBy(c => c.Quantity)
                    .ToList()
                    .ForEach(c => Console.WriteLine($"##{c.Name} - {c.Quantity}"));
            }
        }
    }

    private static void FillTheBag(string[] inputTokens, List<Type> gold, List<Type> gems, List<Type> cash)
    {
        for (int index = 0; index < inputTokens.Length; index+= 2)
        {
            string typeName = inputTokens[index];
            long quantity = long.Parse(inputTokens[index + 1]);
            if(typeName == "Gold")
            {
                TryAddingGold(gold, typeName, quantity);
            }
            else if(typeName.Length == 3)
            {
                TryAddingCash(cash, gems, typeName, quantity);
            }
            else if(typeName.ToLower().EndsWith("gem") && typeName.Length >= 4)
            {
                TryAddingGems(gems, gold, typeName, quantity);
            }
        }
    }

    private static void TryAddingGems(List<Type> gems, List<Type> gold, string typeName, long quantity)
    {
        if(gems.Sum(g => g.Quantity) + quantity <= gold.Sum(g => g.Quantity) && capacityOfBag - quantity >= 0)
        {
            capacityOfBag -= quantity;
            Type currentGem = gems.FirstOrDefault(g => g.Name == typeName);
            if(currentGem == null)
            {
                currentGem = new Type(typeName);
                gems.Add(currentGem);
            }
            currentGem.AddQuantity(quantity);
        }
    }

    private static void TryAddingCash(List<Type> cash, List<Type> gems, string typeName, long quantity)
    {
        if(cash.Sum(c => c.Quantity) + quantity <= gems.Sum(g => g.Quantity) && capacityOfBag - quantity >= 0)
        {
            capacityOfBag -= quantity;
            Type currentCash = cash.FirstOrDefault(c => c.Name == typeName);
            if(currentCash == null)
            {
                currentCash = new Type(typeName);
                cash.Add(currentCash);
            }
            currentCash.AddQuantity(quantity);
        }
    }

    private static void TryAddingGold(List<Type> gold, string typeName, long quantity)
    {
        if(capacityOfBag - quantity >= 0)
        {
            capacityOfBag -= quantity;
            if(gold.Count == 0)
            {
                gold.Add(new Type(typeName));
            }
            gold[0].AddQuantity(quantity);
        }
    }
}