using DeezerApp.Service.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeezerApp.Test.Utilities
{
    public class SongsGenerator
    {
        public static List<Song> ReturnListOfSongs(int numberOfSongs)
        {
            Random random = new Random();
            List<Song> songs = new List<Song>();
            for (int i = 0; i < numberOfSongs; i++)
            {
                songs.Add(new Song()
                {
                    album = new Album() { title = "Temp Album" },
                    artist = new Artist() { name = "Temp Artist" },
                    duration = random.Next(),
                    title = string.Format("Song " + (i + 1))
                });
            }
            return songs;
        }

    }
}
