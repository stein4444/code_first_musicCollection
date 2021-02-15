using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Category
    {
        public Category()
        {
            this.Playlists = new HashSet<Playlist>();
        }
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Playlist> Playlists { get; set; }

    }
}