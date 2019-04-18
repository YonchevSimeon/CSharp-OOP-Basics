namespace BorderControl
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            List<IIdentity> society = GetSociety();
            string detainIdIdentification = Console.ReadLine();
            PrintIntruders(society, detainIdIdentification);
        }

        private static void PrintIntruders(List<IIdentity> society, string detainIdIdentification)
        {
            foreach (IIdentity potentialIntruder in society)
            {
                if (potentialIntruder.Id.EndsWith(detainIdIdentification))
                {
                    Console.WriteLine(potentialIntruder.Id);
                }
            }
        }

        private static List<IIdentity> GetSociety()
        {
            List<IIdentity> society = new List<IIdentity>();
            string input;
            while((input = Console.ReadLine()) != "End")
            {
                string[] inputTokens = input.Split();
                if(inputTokens.Length == 2)
                {
                    string model = inputTokens[0];
                    string id = inputTokens[1];
                    society.Add(new Robot(model, id));
                }
                else
                {
                    string name = inputTokens[0];
                    int age = int.Parse(inputTokens[1]);
                    string id = inputTokens[2];
                    society.Add(new Citizen(name, age, id));
                }
            }
            return society;
        }
    }
}
