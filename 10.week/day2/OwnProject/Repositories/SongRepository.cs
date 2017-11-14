using OwnProject.Entities;
using OwnProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwnProject.Repositories
{
    public class SongRepository
    {
        SongContext SongContext;

        public SongRepository(SongContext songContext)
        {
            SongContext = songContext;
        }

        public List<Song> GetSongs()
        {
            return SongContext.Songs.ToList();
        }

        public void AddSong(string title)
        {
            SongContext.Songs.Add(new Song { Title = title });
            SongContext.SaveChanges();
        }

        public Song SelectSong(string title)
        {
            var selected = (from song in SongContext.Songs
                            where song.Title == title
                            select song).FirstOrDefault();
            return selected;
        }
    }
}
