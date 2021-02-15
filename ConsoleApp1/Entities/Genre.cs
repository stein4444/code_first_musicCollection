using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Genre
    {
        public Genre()
        {
            this.Albums = new HashSet<Album>();
        }
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}