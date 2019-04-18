using DungeonsAndCodeWizards.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Factories
{
    public class CharacterFactory
    {
        public Character CreateCharacter(string factionArg, string characterType, string name)
        {

            Faction faction = new Faction();
            if (factionArg == "CSharp")
            {
                faction = Faction.CSharp;
            }
            else if (factionArg == "Java")
            {
                faction = Faction.Java;
            }
            else
            {
                throw new ArgumentException($"Invalid faction \"{factionArg}\"!");
            }

            Character character = null;
            if (characterType == "Warrior")
            {
                character = new Warrior(name, faction);
            }
            else if (characterType == "Cleric")
            {
                character = new Cleric(name, faction);
            }
            else
            {
                throw new ArgumentException($"Invalid character type \"{characterType}\"!");
            }

            return character;
        }
    }
}
