namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addcustomers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CUSTOMERS (Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES ('Dario Vranjkovic', 1, 1)");
            Sql("INSERT INTO CUSTOMERS (Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES ('Mario Vranjkovic', 0, 2)");
            Sql("INSERT INTO CUSTOMERS (Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES ('Marija Vranjkovic', 0, 3)");
            Sql("INSERT INTO CUSTOMERS (Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES ('Vlado Vranjkovic', 1, 3)");
            Sql("INSERT INTO CUSTOMERS (Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES ('Emilija Vranjkovic', 1, 4)");
        }
        
        public override void Down()
        {
        }
    }
}
