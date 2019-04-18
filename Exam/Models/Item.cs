using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Models
{
    public abstract class Item
    {
        protected Item(int weight)
        {
            this.Weight = weight;
        }

        public int Weight { get; }

        public virtual void AffectCharacter(Character character) { }
    }
}
