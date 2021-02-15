using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    public class Singer
    {
        public Singer()
        {
            this.Tracks = new HashSet<Track>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public int CountryId { get; set; }
        public int AlbumId { get; set; }
        public virtual Country Country { get; set; }
        public virtual Album Album { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
    }
}