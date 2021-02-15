using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Album
    {
        public Album()
        {
            this.Tracks = new HashSet<Track>();
            this.Singers = new HashSet<Singer>();
        }
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }

        public int Year { get; set; }
        public int AlbumRationg { get; set; }
        public int GenreId { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual ICollection<Singer> Singers { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
    }
}