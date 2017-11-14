using Microsoft.EntityFrameworkCore;
using OwnProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwnProject.Entities
{
    public class SongContext : DbContext
    {
        public SongContext(DbContextOptions<SongContext>options) : base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Artist>()
        //        .HasMany(s => s.Songs)
        //        .WithOne(a => a.Artist).IsRequired();

        //    modelBuilder.Entity<Song>()
        //        .HasOne(a => a.Artist)
        //        .WithMany(s => s.Songs).IsRequired();
        //}
    }
}
