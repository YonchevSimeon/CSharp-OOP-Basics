namespace MilitaryElite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            List<Soldier> army = new List<Soldier>();
            string input;
            while((input = Console.ReadLine()) != "End")
            {
                string[] soldierArgs = input.Split();
                string division = soldierArgs[0];
                switch (division)
                {
                    case "Private":
                        Private privateSoldier = 
                            new Private(soldierArgs[1], soldierArgs[2], soldierArgs[3], decimal.Parse(soldierArgs[4]));
                        army.Add(privateSoldier);
                        break;
                    case "LeutenantGeneral":
                        LeutenantGeneral leutenantGeneral 
                            = new LeutenantGeneral(soldierArgs[1], soldierArgs[2], soldierArgs[3], decimal.Parse(soldierArgs[4]));
                        army.Add(leutenantGeneral);
                        GetPrivatesForLeutenantGeneral(leutenantGeneral, army, soldierArgs);
                        break;
                    case "Engineer":
                        if(IsValidCorps(soldierArgs[5]))
                        {
                            Engineer engineer
                            = new Engineer(soldierArgs[1], soldierArgs[2], soldierArgs[3], decimal.Parse(soldierArgs[4]), soldierArgs[5]);
                            army.Add(engineer);
                            GetRepairForEngineer(engineer, soldierArgs);
                        }
                        break;
                    case "Commando":
                        if (IsValidCorps(soldierArgs[5]))
                        {
                            Commando commando
                                = new Commando(soldierArgs[1], soldierArgs[2], soldierArgs[3], decimal.Parse(soldierArgs[4]), soldierArgs[5]);
                            army.Add(commando);
                            GetMissionsForCommando(commando, soldierArgs);
                        }
                        break;
                    case "Spy":
                        Spy spy = new Spy(soldierArgs[1], soldierArgs[2], soldierArgs[3], int.Parse(soldierArgs[4]));
                        army.Add(spy);
                        break;
                    default: break;
                }
            }
            army.ForEach(soldier => Console.WriteLine(soldier));
        }

        private static void GetMissionsForCommando(Commando commando, string[] soldierArgs)
        {
            for (int index = 6; index < soldierArgs.Length; index += 2)
            {
                if(IsValidMissionState(soldierArgs[index + 1]))
                {
                    Mission mission = new Mission(soldierArgs[index], soldierArgs[index + 1]);
                    commando.Missions.Add(mission);
                }
            }
        }

        private static bool IsValidMissionState(string state)
        {
            return state == "inProgress" || state == "Finished";
        }

        private static bool IsValidCorps(string corps)
        {
            return corps == "Airforces" || corps == "Marines";
        }

        private static void GetRepairForEngineer(Engineer engineer, string[] soldierArgs)
        {
            for (int index = 6; index < soldierArgs.Length; index += 2)
            {
                Repair repair = new Repair(soldierArgs[index], int.Parse(soldierArgs[index + 1]));
                engineer.Repairs.Add(repair);   
            }
        }

        private static void GetPrivatesForLeutenantGeneral(LeutenantGeneral leutenantGeneral, List<Soldier> army, string[] soldierArgs)
        {
            for (int index = 5; index < soldierArgs.Length; index++)
            {
                Soldier privateSoldier = army.FirstOrDefault(ps => ps.Id == soldierArgs[index]);
                leutenantGeneral.Privates.Add((Private)privateSoldier);
            }
        }
    }
}
