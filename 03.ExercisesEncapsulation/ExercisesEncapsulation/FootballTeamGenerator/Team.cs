using System;
using System.Linq;
using System.Collections.Generic;

public class Team
{
    private const string TEAM_NAME_ERROR = "A name should not be empty.";
    private const string TEAM_NONEXISTENT_PLAYER_ERROR = "Player {0} is not in {1} team.";
    //private const string TEAM_NONEXISTENT_TEAM_ERORR = "Team {0} does not exist.";

    private string name;
    private List<Player> players;
    
    public Team(string name)
    {
        this.Name = name;
        this.players = new List<Player>();
    }

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(TEAM_NAME_ERROR);
            }
            this.name = value;
        }
    }

    private int AverageRating()
    {
        if (this.players.Count == 0)
        {
            return 0;
        }

        double averageSkillRating = Math.Round(
            this.players.Sum(p => p.Stats.Average()) / this.players.Count);

        return (int)averageSkillRating;
    }

    public void AddPlayer(Player player)
    {
        this.players.Add(player);
    }

    public void RemovePlayer(string playerName)
    {
        Player player = this.players.FirstOrDefault(p => p.Name == playerName);
        if(player == null)
        {
            throw new ArgumentException(string
                .Format(TEAM_NONEXISTENT_PLAYER_ERROR, playerName, this.name));
        }
        this.players.Remove(player);
    }

    public override string ToString()
    {
        return $"{this.name} - {this.AverageRating()}";
    }
}