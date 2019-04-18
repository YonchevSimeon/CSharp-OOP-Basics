using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Models
{
    public class PoisonPotion : Item
    {
        public PoisonPotion() : base(5) { }

        public override void AffectCharacter(Character character)
        {
            if (!character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }
            character.DecreaseHealthFromPoison(20d);
        }
    }
}
