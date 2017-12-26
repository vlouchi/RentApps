namespace RentApps.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovies : DbMigration
    {
        public override void Up()
        {
            try
            {
                Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, Stock) VALUES ('Bangtan Boys',3,2017-11-03, 2017-12-12,3)");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
        
        public override void Down()
        {
            
        }
    }
}
