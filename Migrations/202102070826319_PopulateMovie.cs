namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovie : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStocks, GenreId) VALUES('Hangover', '06-26-2009', '01-01-2020', 4, 2)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStocks, GenreId) VALUES('Die Hard', '07-12-1998','02-01-2020', 8, 1)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStocks, GenreId) VALUES('The Terminator', '10-26-1984','03-01-2020', 3, 1)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStocks, GenreId) VALUES('Toy Story', '11-19-1995','04-01-2020', 1, 3)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStocks, GenreId) VALUES('Titanic', '11-01-1997','05-01-2020', 0, 4)");

        }

        public override void Down()
        {
        } 
    }
}
