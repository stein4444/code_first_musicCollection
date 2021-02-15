using System.Data.Entity;
using System.Linq;

namespace ConsoleApp1
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name=Model1")
        {
            Database.SetInitializer(new Initializer());
        }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Category> Categorys { get; set; }
        public virtual DbSet<Country> Countrys { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Playlist> Playlists { get; set; }
        public virtual DbSet<Singer> Singers { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }
    }
}