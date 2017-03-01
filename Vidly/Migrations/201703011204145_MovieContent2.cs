namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieContent2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MOVIES (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Hangover', 1, '1.1.2001','1.1.2000', 50 )");
            Sql("INSERT INTO MOVIES (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Die Hard', 2, '1.1.2002','1.1.2001', 15 )");
            Sql("INSERT INTO MOVIES (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Titanic', 3, '1.1.2003','1.1.2002', 150 )");
            Sql("INSERT INTO MOVIES (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Mask', 4, '1.1.2004','1.1.2003', 5 )");
        }
        
        public override void Down()
        {
        }
    }
}
