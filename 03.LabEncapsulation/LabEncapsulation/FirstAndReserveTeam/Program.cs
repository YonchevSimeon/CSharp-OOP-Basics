using System;

class Program
{
    static void Main(string[] args)
    {
        Team team = new Team("teamName");
        int numberOfPlayers = int.Parse(Console.ReadLine());
        for (int index = 0; index < numberOfPlayers; index++)
        {
            string[] cmdArgs = Console.ReadLine().Split();
            try
            {
                Person person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
                team.AddPlayer(person);
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
        }
        Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
        Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
    }
}
