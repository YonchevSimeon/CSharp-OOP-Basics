using System;

public class Song
{
    private const int MIN_ARTIST_NAME_LENGTH = 3;
    private const int MAX_ARTIST_NAME_LENGTH = 20;
    private const int MIN_SONG_NAME_LENGTH = 3;
    private const int MAX_SONG_NAME_LENGTH = 30;
    private const int MIN_SONG_MINUTES = 0;
    private const int MAX_SONG_MINUTES = 14;
    private const int MIN_SONG_SECONDS = 0;
    private const int MAX_SONG_SECONDS = 59;

    private const string INVALID_ARTIST_NAME_EXCEPTION = "Artist name should be between {0} and {1} symbols.";
    private const string INVALID_SONG_NAME_EXCEPTION = "Song name should be between {0} and {1} symbols.";
    private const string INVALID_SONG_MINUTES_EXCEPTION = "Song minutes should be between {0} and {1}.";
    private const string INVALID_SONG_SECONDS_EXCEPTION = "Song seconds should be between {0} and {1}.";

    private string artistName;
    private string songName;
    private int songMinutes;
    private int songSeconds;

    public Song(string artistName, string songName, int songMinutes, int songSeconds)
    {
        this.ArtistName = artistName;
        this.SongName = songName;
        this.SongMinutes = songMinutes;
        this.SongSeconds = songSeconds;
    }

    public string ArtistName
    {
        get { return this.artistName; }
        private set
        {
            if(value.Length < MIN_ARTIST_NAME_LENGTH || value.Length > MAX_ARTIST_NAME_LENGTH)
            {
                throw new ArgumentException(string
                    .Format(INVALID_ARTIST_NAME_EXCEPTION, MIN_ARTIST_NAME_LENGTH, MAX_ARTIST_NAME_LENGTH));
            }
            this.artistName = value;
        }
    }

    public string SongName
    {
        get { return this.songName; }
        private set
        {
            if (value.Length < MIN_SONG_NAME_LENGTH || value.Length > MAX_SONG_NAME_LENGTH)
            {
                throw new ArgumentException(string
                    .Format(INVALID_SONG_NAME_EXCEPTION, MIN_SONG_NAME_LENGTH, MAX_SONG_NAME_LENGTH));
            }
            this.songName = value;
        }
    }

    public int SongMinutes
    {
        get { return this.songMinutes; }
        private set
        {
            if (value < MIN_SONG_MINUTES || value > MAX_SONG_MINUTES)
            {
                throw new ArgumentException(string
                    .Format(INVALID_SONG_MINUTES_EXCEPTION, MIN_SONG_MINUTES, MAX_SONG_MINUTES));
            }
            this.songMinutes = value;
        }
    }

    public int SongSeconds
    {
        get { return this.songSeconds; }
        private set
        {
            if(value < MIN_SONG_SECONDS || value > MAX_SONG_SECONDS)
            {
                throw new ArgumentException(string
                    .Format(INVALID_SONG_SECONDS_EXCEPTION, MIN_SONG_SECONDS, MAX_SONG_SECONDS));
            }
            this.songSeconds = value;
        }
    }
}
