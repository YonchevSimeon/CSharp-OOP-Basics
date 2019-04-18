using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        List<Trainer> trainers = new List<Trainer>();
        string input;
        while ((input = Console.ReadLine()) != "Tournament")
        {
            string[] inputTokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string trainerName = inputTokens[0];
            string pokemonName = inputTokens[1];
            string pokemonElement = inputTokens[2];
            int pokemonHealth = int.Parse(inputTokens[3]);
            if (!trainers.Any(t => t.Name == trainerName))
            {
                trainers.Add(new Trainer(trainerName, new Pokemon(pokemonName, pokemonElement, pokemonHealth)));
                continue;
            }
            trainers.Find(t => t.Name == trainerName).Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
        }
        while ((input = Console.ReadLine()) != "End")
        {
            foreach (Trainer trainer in trainers)
            {
                if (trainer.Pokemons.Any(p => p.Element == input))
                {
                    trainer.Badges++;
                }
                else
                {
                    trainer.Pokemons.Select(p => p.Health -= 10).ToList();
                    trainer.Pokemons = trainer.Pokemons.Where(p => p.Health > 0).ToList();
                }
            }
        }
        trainers.OrderBy(t => -t.Badges).ToList().ForEach(t => Console.WriteLine(t));
    }
}
