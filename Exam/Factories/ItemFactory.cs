using DungeonsAndCodeWizards.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Factories
{
    public class ItemFactory
    {
        public Item CreateItem(string itemName)
        {

            Item item;
            if (itemName == "HealthPotion")
            {
                item = new HealthPotion();
            }
            else if (itemName == "PoisonPotion")
            {
                item = new PoisonPotion();
            }
            else if (itemName == "ArmorRepairKit")
            {
                item = new ArmorRepairKit();
            }
            else
            {
                throw new ArgumentException($"Invalid item \"{itemName}\"!");
            }
            return item;
        }
    }
}
