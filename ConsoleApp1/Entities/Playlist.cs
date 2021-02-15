using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Playlist
    {
        public Playlist()
        {
            this.Tracks = new HashSet<Track>();
        }
        public int Id { get; set; }
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }

    }
}