namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovieGenreAndMovieDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MyProperty = c.Int(nullable: false),
                        MoviesGenre_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MovieGenres", t => t.MoviesGenre_Id)
                .Index(t => t.MoviesGenre_Id);
            
            CreateTable(
                "dbo.MovieGenres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Genre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "MoviesGenre_Id", "dbo.MovieGenres");
            DropIndex("dbo.Movies", new[] { "MoviesGenre_Id" });
            DropTable("dbo.MovieGenres");
            DropTable("dbo.Movies");
        }
    }
}
