namespace BirthdayCelebrations
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            List<IBirthdate> beings = GetBeigns();
            string yearToLookFor = Console.ReadLine();
            PrintBeings(beings, yearToLookFor);
        }

        private static List<IBirthdate> GetBeigns()
        {
            List<IBirthdate> beings = new List<IBirthdate>();
            string input;
            while((input = Console.ReadLine()) != "End")
            {
                string[] inputTokens = input.Split();

                string being = inputTokens[0];
                string name = inputTokens[1];

                if (being == "Citizen")
                {
                    int age = int.Parse(inputTokens[2]);
                    string id = inputTokens[3];
                    string birthdate = inputTokens[4];
                    beings.Add(new Citizen(name, age, id, birthdate));
                }
                else if(being == "Pet")
                {
                    string birthdate = inputTokens[2];
                    beings.Add(new Pet(name, birthdate));
                }
            }
            return beings;
        }

        private static void PrintBeings(List<IBirthdate> beings, string yearToLookFor)
        {
            foreach (IBirthdate being in beings)
            {
                if (being.Birthdate.EndsWith(yearToLookFor))
                {
                    Console.WriteLine(being.Birthdate);
                }
            }
        }
    }
}
