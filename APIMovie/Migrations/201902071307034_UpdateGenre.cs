namespace APIMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Genres(Name) values('Action')");
            Sql("insert into Genres(Name) values('Comedy')");
            Sql("insert into Genres(Name) values('Crime')");
            Sql("insert into Genres(Name) values('Drama')");
            Sql("insert into Genres(Name) values('Fantasy')");
            Sql("insert into Genres(Name) values('Historical')");
            Sql("insert into Genres(Name) values('Horror')");
            Sql("insert into Genres(Name) values('Mystery')");
            Sql("insert into Genres(Name) values('Philosophical')");
            Sql("insert into Genres(Name) values('Political')");
            Sql("insert into Genres(Name) values('Romance')");
            Sql("insert into Genres(Name) values('Science fiction')");
            Sql("insert into Genres(Name) values('Thriller')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id=1");
            Sql("DELETE FROM Genres WHERE Id=2");
            Sql("DELETE FROM Genres WHERE Id=3");
            Sql("DELETE FROM Genres WHERE Id=4");
            Sql("DELETE FROM Genres WHERE Id=5");
            Sql("DELETE FROM Genres WHERE Id=6");
            Sql("DELETE FROM Genres WHERE Id=7");
            Sql("DELETE FROM Genres WHERE Id=8");
            Sql("DELETE FROM Genres WHERE Id=9");
            Sql("DELETE FROM Genres WHERE Id=10");
            Sql("DELETE FROM Genres WHERE Id=11");
            Sql("DELETE FROM Genres WHERE Id=12");
            Sql("DELETE FROM Genres WHERE Id=13");

        }
    }
}
