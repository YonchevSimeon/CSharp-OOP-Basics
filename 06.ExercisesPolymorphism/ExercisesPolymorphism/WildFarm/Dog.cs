using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models;

namespace WildFarm
{
    class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion) { }

        protected override Type[] PreferredFoods => new Type[] { typeof(Meat) };

        protected override double WeightIncreaseMultiplier => 0.40;

        public override string MakeSound()
        {
            return "Woof!";
        }

        public override string ToString()
        {
            string fromBase = base.ToString();
            string result = string.Format(fromBase, string.Empty);
            return result;
        }
    }
}
