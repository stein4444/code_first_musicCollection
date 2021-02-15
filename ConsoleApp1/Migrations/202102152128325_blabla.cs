namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blabla : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tracks", "SingerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Tracks", "SingerId");
            AddForeignKey("dbo.Tracks", "SingerId", "dbo.Singers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tracks", "SingerId", "dbo.Singers");
            DropIndex("dbo.Tracks", new[] { "SingerId" });
            DropColumn("dbo.Tracks", "SingerId");
        }
    }
}
