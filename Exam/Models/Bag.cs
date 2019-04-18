using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonsAndCodeWizards.Models
{
    public abstract class Bag
    {
        private const int DefaultValue = 100;

        protected Bag(int capacity)
        {
            this.Items = new List<Item>();
            this.Capacity = 100;
        }

        public int Capacity { get; protected set; }

        public double Load => this.Items.Sum(i => i.Weight);

        public List<Item> Items  { get; protected set; }

        public void AddItem(Item item)
        {
            if (this.Capacity < this.Load + item.Weight)
            {
                throw new InvalidOperationException("Bag is full!");
            }

            this.Items.Add(item);
        }

        public Item GetItem(string name)
        {
            if(this.Items.Count == 0)
            {
                throw new ArgumentException("Bag is empty!");
            }

            if(!this.Items.Any(i => i.GetType().Name == name))
            {
                throw new ArgumentException($"No item with name {name} in bag!");
            }

            Item item = Items.SingleOrDefault(i => i.GetType().Name == name);

            this.Items.Remove(item);

            return item;
        }
        
    }
}
