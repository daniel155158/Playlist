using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Playlist.Models;
using System.Diagnostics;

namespace Playlist.DAL
{
    public class PlaylistInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PlaylistContext>
    {
        protected override void Seed(PlaylistContext context)
        {
            // Singer's seed data
            var singers = new List<Singer>
            {
            new Singer{Name="IVE"},
            new Singer{Name="LE SSERAFIM"},
            new Singer{Name="NMIXX"},
            new Singer{Name="NewJeans"}
            };
            singers.ForEach(singer => context.Singers.Add(singer));
            context.SaveChanges();

            // Album's seed data
            var albums = new List<Album>
            {
            new Album{Title="I've IVE",ReleaseDate=DateTime.Parse("2023-04-10"),SingerID=1},
            new Album{Title="After LIKE",ReleaseDate=DateTime.Parse("2022-08-22"),SingerID=1},
            new Album{Title="UNFORGIVEN",ReleaseDate=DateTime.Parse("2023-05-01"),SingerID=2},
            new Album{Title="ENTWURF",ReleaseDate=DateTime.Parse("2022-09-19"),SingerID=3},
            new Album{Title="OMG",ReleaseDate=DateTime.Parse("2023-01-02"),SingerID=4},
            new Album{Title="New Jeans",ReleaseDate=DateTime.Parse("2022-08-01"),SingerID=4}
            };
            albums.ForEach(album => context.Albums.Add(album));
            context.SaveChanges();

            // Song's seed data
            var songs = new List<Song>
            {
            new Song{Title="I AM",AlbumID=1},
            new Song{Title="Kitsch",AlbumID=1},
            new Song{Title="NOT YOUR GIRL",AlbumID=1},
            new Song{Title="After LIKE",AlbumID=2},
            new Song{Title="UNFORGIVEN (feat. Nile Rodgers)",AlbumID=3},
            new Song{Title="DICE",AlbumID=4},
            new Song{Title="OMG",AlbumID=5},
            new Song{Title="Attention",AlbumID=6},
            new Song{Title="Hype Boy",AlbumID=6}
            };
            songs.ForEach(song => context.Songs.Add(song));
            context.SaveChanges();
        }
    }
}