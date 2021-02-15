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

        //public IQueryable<Track> GetTracksByRating(string singer)
        //{
        //    return ctx.Tracks.OrderByDescending(s => s.)
        //}
    }
}
