using System;

public class Player
{
    private const int STAT_MIN_VALUE = 0;
    private const int STAT_MAX_VALUE = 100;
    private const string PLAYER_NAME_ERROR = "A name should not be empty.";
    private const string PLAYER_STAT_ERROR = "{0} should be between {1} and {2}.";

    private string[] statsType = new string[] 
    {
        "Endurance",
        "Sprint",
        "Dribble",
        "Passing",
        "Shooting"
    };

    private string name;
    private int[] stats;

    public Player(string name, int[] stats)
    {
        this.Name = name;
        this.Stats = stats;
    }

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(PLAYER_NAME_ERROR);
            }
            this.name = value;
        }
    }

    public int[] Stats
    {
        get { return this.stats; }
        private set
        {
            this.stats = new int[5];
            for (int index = 0; index < 5; index++)
            {
                if(value[index] < STAT_MIN_VALUE || value[index] > STAT_MAX_VALUE)
                {
                    throw new ArgumentException(string
                        .Format(PLAYER_STAT_ERROR, statsType[index], STAT_MIN_VALUE, STAT_MAX_VALUE));
                }
                this.stats[index] = value[index];
            }
        }
    }
}
