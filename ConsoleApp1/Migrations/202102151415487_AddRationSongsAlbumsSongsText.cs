namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRationSongsAlbumsSongsText : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        Year = c.Int(nullable: false),
                        AlbumRationg = c.Int(nullable: false),
                        GenreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.GenreId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Singers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        CountryId = c.Int(nullable: false),
                        AlbumId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Albums", t => t.AlbumId, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId)
                .Index(t => t.AlbumId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tracks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Duration = c.Time(nullable: false, precision: 7),
                        Rating = c.Int(nullable: false),
                        SongText = c.String(),
                        TimesListened = c.Int(nullable: false),
                        AlbumId = c.Int(nullable: false),
                        PlayListId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Albums", t => t.AlbumId, cascadeDelete: true)
                .ForeignKey("dbo.Playlists", t => t.PlayListId, cascadeDelete: true)
                .Index(t => t.AlbumId)
                .Index(t => t.PlayListId);
            
            CreateTable(
                "dbo.Playlists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tracks", "PlayListId", "dbo.Playlists");
            DropForeignKey("dbo.Playlists", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Tracks", "AlbumId", "dbo.Albums");
            DropForeignKey("dbo.Singers", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Singers", "AlbumId", "dbo.Albums");
            DropForeignKey("dbo.Albums", "GenreId", "dbo.Genres");
            DropIndex("dbo.Playlists", new[] { "CategoryId" });
            DropIndex("dbo.Tracks", new[] { "PlayListId" });
            DropIndex("dbo.Tracks", new[] { "AlbumId" });
            DropIndex("dbo.Singers", new[] { "AlbumId" });
            DropIndex("dbo.Singers", new[] { "CountryId" });
            DropIndex("dbo.Albums", new[] { "GenreId" });
            DropTable("dbo.Categories");
            DropTable("dbo.Playlists");
            DropTable("dbo.Tracks");
            DropTable("dbo.Countries");
            DropTable("dbo.Singers");
            DropTable("dbo.Genres");
            DropTable("dbo.Albums");
        }
    }
}
