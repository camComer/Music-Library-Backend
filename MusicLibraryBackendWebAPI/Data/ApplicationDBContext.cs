using Microsoft.EntityFrameworkCore;
using MusicLibraryBackendWebAPI.Models;

namespace MusicLibraryBackendWebAPI.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    Id = 1,
                    Title = "Amazing",
                    Artist = "Kanye West",
                    Album = "808s & Heartbreak",
                    ReleaseDate = 2008,
                    Genre = "Hip-Hop"
                },
                new Song
                {
                    Id = 2,
                    Title = "Heartless",
                    Artist = "Kanye West",
                    Album = "808s & Heartbreak",
                    ReleaseDate = 2008,
                    Genre = "Hip-Hop"
                },
                new Song
                {
                    Id = 3,
                    Title = "DNA",
                    Artist = "Kendrick Lamar",
                    Album = "DAMN",
                    ReleaseDate = 2017,
                    Genre = "Hip-Hop"
                },
                new Song
                {
                    Id = 4,
                    Title = "PRIDE",
                    Artist = "Kendrick Lamar",
                    Album = "DAMN",
                    ReleaseDate = 2017,
                    Genre = "Hip-Hop"
                },
                new Song
                {
                    Id = 5,
                    Title = "Borderline",
                    Artist = "Tame Impala",
                    Album = "The Slow Rush",
                    ReleaseDate = 2020,
                    Genre = "Psychedelic Rock"
                },
                new Song
                {
                    Id = 6,
                    Title = "Let It Happen",
                    Artist = "Tame Impala",
                    Album = "Currents",
                    ReleaseDate = 2015,
                    Genre = "Psychedelic Rock"
                },
                new Song
                {
                    Id = 7,
                    Title = "Stronger Than Me",
                    Artist = "Amy Winehouse",
                    Album = "Frank",
                    ReleaseDate = 2003,
                    Genre = "Jazz"
                },
                new Song
                {
                    Id = 8,
                    Title = "Love Is A Losing Game",
                    Artist = "Amy Winehouse",
                    Album = "Back to Black",
                    ReleaseDate = 2006,
                    Genre = "Jazz"
                },
                new Song
                {
                    Id = 9,
                    Title = "Pink Matter",
                    Artist = "Frank Ocean",
                    Album = "channel ORANGE",
                    ReleaseDate = 2012,
                    Genre = "Neo Soul"
                },
                new Song
                {
                    Id = 10,
                    Title = "Nights",
                    Artist = "Frank Ocean",
                    Album = "Blonde",
                    ReleaseDate = 2016,
                    Genre = "Neo Soul"
                });
        }
    }
}
