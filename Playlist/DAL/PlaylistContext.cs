using Playlist.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Playlist.DAL
{
    public class PlaylistContext : DbContext
    {

        // Specify the connection string
        public PlaylistContext() : base("PlaylistContext")
        { 
        }

        public DbSet<Singer> Singers { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Specify singular table names (避免table自動產生為複數名稱)
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}