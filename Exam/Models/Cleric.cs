using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Models
{
    public class Cleric : Character, IHealable
    {
        public Cleric(string name, Faction faction)
            : base(name, 100, 50, 40, new Backpack(), faction) { }

        public override double BaseHealth => 50;

        public override double BaseArmor => 25;

        public override double RestHealMultiplier => 0.5;

        public void Heal(Character character)
        {
            if (!this.IsAlive && !character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!"); ;
            }

            if(this.Faction != character.Faction)
            {
                throw new InvalidOperationException("Cannot heal enemy character!"); ;
            }

            character.IncreaseHealth(this.AbilityPoints);
        }
    }
}
