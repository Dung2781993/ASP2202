namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingSchool : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.School",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.ID);

            AddColumn("dbo.Course", "SchoolId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropTable("dbo.School");
        }
    }
}
