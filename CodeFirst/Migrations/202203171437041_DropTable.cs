namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.School");
        }
        
        public override void Down()
        {

        }
        //3 local, dev, production (relase)
        //Elasbean stalk (AWS) -> migration -> dev (Update db) -> (localdb)\MSSQLLocalDB
        // Poruction -migration -> production -> Codefirst.test
    }
}
