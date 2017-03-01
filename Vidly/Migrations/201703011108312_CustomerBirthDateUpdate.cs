namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerBirthDateUpdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '1.1.2001' WHERE Id = 1");
            Sql("UPDATE Customers SET BirthDate = '2.2.2002' WHERE Id = 2");
            Sql("UPDATE Customers SET BirthDate = '3.3.2003' WHERE Id = 3");
            Sql("UPDATE Customers SET BirthDate = '4.4.2004' WHERE Id = 4");
            Sql("UPDATE Customers SET BirthDate = '5.5.2005' WHERE Id = 5");
        }
        
        public override void Down()
        {
        }
    }
}
