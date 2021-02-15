using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DAL
    {
        private MyDbContext ctx;

        public DAL()
        {
            ctx = new MyDbContext();
        }

        public IQueryable<Track> GetTracks()
        {
            return ctx.Tracks;
        }
        //get top 3 tracks 
        public IQueryable<Track> GetTracksByRating(string name)
        {
            return ctx.Tracks.OrderByDescending(s => s.Rating).Where(a => a.Singer.Name == name).Take(3);
        }

        //search trak by singer or part of text  
        public IQueryable<Track> GetByPartOfTextOrName(string txt)
        {
            return ctx.Tracks.Where(s => s.Name.Contains(txt) || s.SongText.Contains(txt));
        }
        //Відображення треків певного альбома, кількість прослуховувань яких більша середнього значення по всіх треках даного альбома
        public IQueryable<Track> AvgRating(string album)
        {
            return ctx.Tracks.Where(s => s.Rating > ctx.Tracks.Average(r => r.Rating) && s.Album.Name == album);
        }
    }
}
