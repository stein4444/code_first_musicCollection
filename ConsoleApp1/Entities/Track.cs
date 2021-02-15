using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    public class Track
    {
        public int Id { get; set; }
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public int Rating { get; set; }
        public string SongText { get; set; }
        public int TimesListened { get; set; }
        public int AlbumId { get; set; }
        public int PlayListId { get; set; }
        public int SingerId { get; set; }
        public virtual Singer Singer { get; set; }
        public virtual Album Album { get; set; }
        public virtual Playlist Playlist { get; set; }

    }
}