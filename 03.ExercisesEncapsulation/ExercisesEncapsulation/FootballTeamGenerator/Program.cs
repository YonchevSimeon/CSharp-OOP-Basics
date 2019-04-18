namespace FootballTeamGenerator
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        private const string TEAM_NONEXISTENT_TEAM_ERORR = "Team {0} does not exist.";

        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            string input;
            while((input = Console.ReadLine()) != "END")
            {
                string[] inputTokens = input.Split(';', StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    string command = inputTokens[0];
                    string teamName = inputTokens[1];
                    
                    switch (command)
                    {
                        case "Team":
                            teams.Add(new Team(teamName));
                            break;
                        case "Add":
                            Team addTeam = GetExistingTeam(teamName, teams);
                            string playerName = inputTokens[2];
                            int[] playerStats = inputTokens.Skip(3).Select(int.Parse).ToArray();
                            Player player = new Player(playerName, playerStats);
                            addTeam.AddPlayer(player);
                            break;
                        case "Remove":
                            Team removeTeam = GetExistingTeam(teamName, teams);
                            string removingPlayerName = inputTokens[2];
                            removeTeam.RemovePlayer(removingPlayerName);
                            break;
                        case "Rating":
                            Team ratingTeam = GetExistingTeam(teamName, teams);
                            Console.WriteLine(ratingTeam);
                            break;
                    }
                    
                }
                catch(ArgumentException argEx)
                {
                    Console.WriteLine(argEx.Message);
                }
            }
        }

        private static Team GetExistingTeam(string teamName, List<Team> teams)
        {
            Team team = teams.FirstOrDefault(t => t.Name == teamName);
            if (team == null)
            {
                throw new ArgumentException(string.Format(TEAM_NONEXISTENT_TEAM_ERORR, teamName));
            }
            return team;
        }
    }
}
