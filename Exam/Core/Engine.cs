using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonsAndCodeWizards.Core
{
    public class Engine
    {
        private DungeonMaster dungeonMaster;
        public Engine()
        {
            this.dungeonMaster = new DungeonMaster();
        }

        public void Run()
        {
            string input;
            while ((input = Console.ReadLine()) != null)
            {
                string[] inputArgs = input.Split();

                string command = inputArgs[0];

                string[] args = inputArgs.Skip(1).ToArray();

                try
                {
                    switch (command)
                    {
                        case "JoinParty": Console.WriteLine(this.dungeonMaster.JoinParty(args)); break;
                        case "AddItemToPool": Console.WriteLine(this.dungeonMaster.AddItemToPool(args)); break;
                        case "PickUpItem": Console.WriteLine(this.dungeonMaster.PickUpItem(args)); break;
                        case "UseItem": Console.WriteLine(this.dungeonMaster.UseItem(args)); break;
                        case "UseItemOn": Console.WriteLine(this.dungeonMaster.UseItemOn(args)); break;
                        case "GiveCharacterItem": Console.WriteLine(this.dungeonMaster.GiveCharacterItem(args)); break;
                        case "GetStats": Console.WriteLine(this.dungeonMaster.GetStats()); ; break;
                        case "Attack": Console.WriteLine(this.dungeonMaster.Attack(args)); break;
                        case "Heal": Console.WriteLine(this.dungeonMaster.Heal(args)); break;
                        case "EndTurn": Console.WriteLine(this.dungeonMaster.EndTurn()); break;
                        case "IsGameOver": bool isGameOver = this.dungeonMaster.IsGameOver();
                            if (isGameOver == true)
                                return;
                            break;
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                catch(InvalidOperationException ipe)
                {
                    Console.WriteLine(ipe.Message);
                }
            }
        }
    }
}
