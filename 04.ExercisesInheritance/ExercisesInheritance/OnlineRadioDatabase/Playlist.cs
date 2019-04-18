using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Playlist
{
    private List<Song> songs;

    public Playlist()
    {
        this.songs = new List<Song>();
    }

    public List<Song> Songs
    {
        get { return this.songs; }
        private set { this.songs = value; }
    }

    public void AddSong(Song song)
    {
        this.Songs.Add(song);
    }

    private TimeSpan TotalSongsLength()
    {
        int totalSongsSeconds = 0;
        foreach (Song song in this.songs)
        {
            totalSongsSeconds += song.SongSeconds;
            totalSongsSeconds += song.SongMinutes * 60;
        }
        return TimeSpan.FromSeconds(totalSongsSeconds);
    }

    public override string ToString()
    {
        //TimeSpan t = TimeSpan.FromSeconds(TotalSongsSeconds());
        TimeSpan t = TotalSongsLength();
        StringBuilder builder = new StringBuilder();
        builder
            .AppendLine($"Songs added: {this.songs.Count}")
            .AppendLine($"Playlist length: {t.Hours}h {t.Minutes}m {t.Seconds}s");
        return builder.ToString();
    }
}
