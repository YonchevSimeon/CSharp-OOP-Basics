using DungeonsAndCodeWizards.Factories;
using DungeonsAndCodeWizards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonsAndCodeWizards.Core
{
    public class DungeonMaster
    {
        private bool gameOver;
        private int lastSurvivorRounds;
        List<Character> party;
        Stack<Item> items;
        private CharacterFactory cf;
        private ItemFactory ifs;
        public DungeonMaster()
        {
            this.ifs = new ItemFactory();
            this.cf = new CharacterFactory();
            this.gameOver = false;
            this.lastSurvivorRounds = 1;
            this.party = new List<Character>();
            this.items = new Stack<Item>();
        }



        public string JoinParty(string[] args)
        {
            string factionArg = args[0];
            string characterType = args[1];
            string name = args[2];
            Character character = cf.CreateCharacter(factionArg, characterType, name);
            this.party.Add(character);
            return $"{character.Name} joined the party!";
        }

        public string AddItemToPool(string[] args)
        {
            string itemName = args[0];
            Item item = ifs.CreateItem(itemName);

            this.items.Push(item);
            return $"{itemName} added to pool.";
        }

        public string PickUpItem(string[] args)
        {
            string characterName = args[0];

            Character character;
            if (!party.Any(c => c.Name == characterName))
            {
                throw new ArgumentException($"Character {characterName} not found!");
            }
            character = party.FirstOrDefault(c => c.Name == characterName);

            if(this.items.Count == 0)
            {
                throw new ArgumentException("No items left in pool!");
            }

            Item item = items.Pop();

            character.Bag.AddItem(item);

            return $"{character.Name} picked up {item.GetType().Name}!";
        }

        public string UseItem(string[] args)
        {
            string characterName = args[0];
            string itemName = args[1];

            if(!party.Any(c => c.Name == characterName))
            {
                throw new ArgumentException($"Character {characterName} not found!");
            }
            
            Character character = party.FirstOrDefault(c => c.Name == characterName);

            Item item = character.Bag.Items.FirstOrDefault(i => i.GetType().Name == itemName);

            character.UseItem(item);

            return $"{character.Name} used {itemName}.";
        }

        public string UseItemOn(string[] args)
        {
            string giverName = args[0];
            string receiverName = args[1];
            string itemName = args[2];

            if(!party.Any(c => c.Name == giverName))
            {
                throw new ArgumentException($"Character {giverName} not found!");
            }

            if(!party.Any(c => c.Name == receiverName))
            {
                throw new ArgumentException($"Character {receiverName} not found!");
            }

            Character giver = party.SingleOrDefault(c => c.Name == giverName);
            Character receiver = party.SingleOrDefault(c => c.Name == receiverName);
            Item item = giver.Bag.GetItem(itemName);

            giver.UseItemOn(item, receiver);

            return $"{giver.Name} used {itemName} on {receiver.Name}";
            
        }

        public string GiveCharacterItem(string[] args)
        {
            string giverName = args[0];
            string receiverName = args[1];
            string itemName = args[2];

            if (!party.Any(c => c.Name == giverName))
            {
                throw new ArgumentException($"Character {giverName} not found!");
            }

            if (!party.Any(c => c.Name == receiverName))
            {
                throw new ArgumentException($"Character {receiverName} not found!");
            }

            Character giver = party.SingleOrDefault(c => c.Name == giverName);
            Character receiver = party.SingleOrDefault(c => c.Name == receiverName);
            Item item = giver.Bag.Items.FirstOrDefault(i => i.GetType().Name == itemName);

            giver.GiveCharacterItem(item, receiver);


            return $"{giverName} gave {receiverName} {itemName}";
        }

        public string GetStats()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Character character in party.OrderByDescending(c => c.IsAlive == true).ThenBy(c => -c.Health))
            {
                sb.AppendLine(character.ToString());
            }
            return sb.ToString().Trim();
        }

        public string Attack(string[] args)
        {
            string attackerName = args[0];
            string receiverName = args[1];



            if (!party.Any(c => c.Name == attackerName))
            {
                throw new ArgumentException($"{attackerName} cannot attack!");
            }

            if (!party.Any(c => c.Name == receiverName))
            {
                throw new ArgumentException($"Character {receiverName} not found!");
            }


            Character attacker = party.SingleOrDefault(c => c.Name == attackerName);
            //if (attacker.GetType().Name != "Warrior")
            //{
            //    
            //}

            Character receiver = party.SingleOrDefault(c => c.Name == receiverName);

            ((Warrior)attacker).Attack(receiver);


            if (!receiver.IsAlive)
            {
                return $"{attackerName} attacks {receiverName} for {attacker.AbilityPoints} hit points! {receiverName} has {receiver.Health}/{receiver.BaseHealth} " +
                    $"HP and {receiver.Armor}/{receiver.BaseArmor} AP left!{Environment.NewLine}{receiver.Name} is dead!";
            }


            return $"{attackerName} attacks {receiverName} for {attacker.AbilityPoints} hit points! {receiverName} has {receiver.Health}/{receiver.BaseHealth} HP and {receiver.Armor}/{receiver.BaseArmor} AP left!";
        }

        public string Heal(string[] args)
        {
            string healerName = args[0];
            string healingReceiverName = args[1];

            if (!party.Any(c => c.Name == healingReceiverName))
            {
                throw new ArgumentException($"Character {healingReceiverName} not found!");
            }

            if (!party.Any(c => c.Name == healerName))
            {
                throw new ArgumentException($"Character {healerName} not found!");
            }

            Character healer = party.SingleOrDefault(c => c.Name == healerName);
            if (healer.GetType().Name != "Cleric")
            {
                throw new ArgumentException($"{healerName} cannot heal!");
            }

            Character receiver = party.SingleOrDefault(c => c.Name == healingReceiverName);
            StringBuilder sb = new StringBuilder();
            ((Cleric)healer).Heal(receiver);

            return $"{healer.Name} heals {receiver.Name} for {healer.AbilityPoints}! {receiver.Name} has {receiver.Health} health now!";
        }

        public string EndTurn()
        {
            StringBuilder sb = new StringBuilder();

            if(party.Count <= 1)
            {
                this.lastSurvivorRounds++;
            }

            foreach (Character character in party)
            {
                if (character.IsAlive)
                {
                    double healthBeforeRestring = character.Health;
                    character.Rest();
                    sb.AppendLine($"{character.Name} rests ({healthBeforeRestring} => {character.Health})");
                }
            }

            return sb.ToString().Trim();
        }

        public bool IsGameOver()
        {
            if(this.party.Count == 1 && this.lastSurvivorRounds > 1)
            {
                this.gameOver = true;
            }
            return this.gameOver;
        }

    }
}
