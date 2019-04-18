using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Models
{
    public class Backpack : Bag
    {
        private const int DefaultValue = 100;

        public Backpack() : base(DefaultValue) { }
    }
}
