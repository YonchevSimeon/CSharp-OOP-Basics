using System;
using WildFarm.Models;

namespace WildFarm
{
    class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion) { }

        protected override Type[] PreferredFoods => new Type[] { typeof(Fruit), typeof(Vegetable) };

        protected override double WeightIncreaseMultiplier => 0.10;

        public override string MakeSound()
        {
            return "Squeak";
        }

        public override string ToString()
        {
            string fromBase = base.ToString();
            string result = string.Format(fromBase, string.Empty);
            return result;
        }
    }
}
