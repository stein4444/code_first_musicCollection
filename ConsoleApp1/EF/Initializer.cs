using System.Data.Entity;

namespace ConsoleApp1
{
    internal class Initializer : CreateDatabaseIfNotExists<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {
            base.Seed(context);
            //init Albums 
            //init Category
            Category categoryHeavy = context.Categorys.Add(new Category() { Name = "Heavy" });
            context.SaveChanges();
            //init Country
            Country ctryUsa = context.Countrys.Add(new Country() { Name = "USA" });
            context.SaveChanges();
            //init Genre
            Genre genreMetal = context.Genres.Add(new Genre() { Name = "Metal"});
            Genre Rock = context.Genres.Add(new Genre() { Name = "Rock"});
            context.SaveChanges();
            Album albumMetlica = context.Albums.Add(new Album() { Name = "Metallica", Year = 1991, GenreId = 1 });
            Album albumLouad = context.Albums.Add(new Album() { Name = "Load", Year = 1996, GenreId = 1 });
            context.SaveChanges();
            //init playlist
            Playlist playListMot = context.Playlists.Add(new Playlist() { Name = "Motivation", CategoryId = 1});
            context.SaveChanges();
            //init singers 
            Singer singerBob = context.Singers.Add(new Singer() { Name = "Bob", Surname = "Ulrih", AlbumId = 1, CountryId = 1 });
            context.SaveChanges();
            //init songs 
            Track trackUnforgiven = context.Tracks.Add(new Track() {Name = "The Unforgiven", AlbumId = 1, PlayListId = 1, Duration = new System.TimeSpan(10)});

            context.SaveChanges();
        }
    }
}