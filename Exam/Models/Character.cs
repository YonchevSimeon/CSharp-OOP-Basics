using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Models
{
    public abstract class Character
    {
        //throw new InvalidOperationException("Must be alive to perform this action!");

        private string name;
        private double health;
        private double armor;
        
        protected Character(string name, double health, double armor, double abilityPoints, Bag bag, Faction faction)
        {
            this.Name = name;
            this.Health = health;
            this.Armor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
            this.Faction = faction;
            this.IsAlive = true;
        }

        public string Name
        {
            get => this.name;
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace!");
                }
                this.name = value;
            }
        }

        public virtual double BaseHealth => 100;

        public virtual double BaseArmor => 100;

        public double Health
        {
            get => this.health;
            protected set
            {
                if(value < 0)
                {
                    throw new ArgumentException("");
                }

                this.health = Math.Min(value, this.BaseHealth);
            }

        }

        public double Armor
        {
            get => this.armor;
            protected set
            {
                if(value < 0)
                {
                    throw new ArgumentException("");
                }

                this.armor = Math.Min(value, this.BaseArmor);
            }
        }

        public double AbilityPoints { get; protected set; }

        public Bag Bag { get; protected set; }

        public bool IsAlive { get; protected set; }

        public Faction Faction { get; protected set; }

        public virtual double RestHealMultiplier => 0.2;

        public void TakeDamage(double hitPoints)
        {
            if (!IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }
            if(this.Armor < hitPoints)
            {
                double currentArmorBeforeTakingDamage = this.Armor;
                this.Armor = 0;
                hitPoints -= currentArmorBeforeTakingDamage;
                this.Health -= hitPoints;
                if(this.Health <= 0)
                {
                    this.IsAlive = false;
                }
            }
            else
            {
                this.Health -= hitPoints;
                if(this.Health <= 0)
                {
                    this.IsAlive = false;
                }
            }
        }

        public void Rest()
        {
            if (!IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            this.Health = Math.Min(this.BaseHealth, this.Health += (this.BaseHealth * this.RestHealMultiplier));
        }

        public void UseItem(Item item)
        {
            if (!IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            item.AffectCharacter(this);

            this.Bag.Items.Remove(item);
        }

        public void UseItemOn(Item item, Character character)
        {
            if(!this.IsAlive || !character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            character.UseItem(item);
            this.Bag.Items.Remove(item);
        }

        public void GiveCharacterItem(Item item, Character character)
        {
            if(!this.IsAlive || !character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            character.Bag.AddItem(item);
            this.Bag.Items.Remove(item);
        }

        public void ReceiveItem(Item item)
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            this.Bag.AddItem(item);
        }

        public void IncreaseHealth(double hp)
        {
            this.Health = Math.Min(BaseHealth, this.Health + hp);
        }

        public void DecreaseHealthFromPoison(double hp)
        {
            this.Health -= hp;
            if(this.Health <= 0)
            {
                IsAlive = false;
            }
        }

        public void RestoreArmorToBase()
        {
            this.Armor = this.BaseArmor;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Name} - HP: {this.Health}, AP: {this.Armor}/{this.BaseArmor}, Status ");
            if (IsAlive)
            {
                sb.AppendLine("Alive");
            }
            else
            {
                sb.AppendLine("Dead");
            }
            return sb.ToString().Trim();
        }

    }
}
