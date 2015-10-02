namespace TechProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Chnges2oct1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "DOB", c => c.DateTime());
            AlterColumn("dbo.Students", "AdYear", c => c.DateTime());
            AlterColumn("dbo.Students", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Students", "ModifiedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "ModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Students", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Students", "AdYear", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Students", "DOB", c => c.DateTime(nullable: false));
        }
    }
}
