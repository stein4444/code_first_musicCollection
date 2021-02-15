using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Country
    {
        public Country()
        {
            this.Singers = new HashSet<Singer>();
        }
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        // NAVIGATION PROPERTIES
        public virtual ICollection<Singer> Singers { get; set; }
    }
}