﻿using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models;

namespace WildFarm
{
    class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed) { }

        protected override Type[] PreferredFoods => new Type[] { typeof(Meat) };

        public override string MakeSound()
        {
            return "ROAR!!!";
        }
    }
}
