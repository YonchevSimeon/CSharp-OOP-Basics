
namespace OnlineRadioDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Playlist playlist = GetPlaylist();
            Console.Write(playlist);
        }

        private static Playlist GetPlaylist()
        {
            Playlist playlist = new Playlist();
            int numberOfSongs = int.Parse(Console.ReadLine());
            for (int curr = 0; curr < numberOfSongs; curr++)
            {
                try
                {
                    string[] inputArgs = Console.ReadLine().Split(';');
                    string artistName = inputArgs[0];
                    string songName = inputArgs[1];
                    string songDuration = inputArgs[2];
                    int[] songArgs;
                    try
                    {
                        songArgs = songDuration.Split(':').Select(int.Parse).ToArray();
                    }
                    catch
                    {
                        throw new ArgumentException("Invalid song length.");
                    }
                    int songMinutes = songArgs[0];
                    int songSeconds = songArgs[1];
                    Song song = new Song(artistName, songName, songMinutes, songSeconds);
                    playlist.AddSong(song);
                    Console.WriteLine("Song added.");
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
            return playlist;
        }
    }
}
