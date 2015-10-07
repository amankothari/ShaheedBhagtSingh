namespace TechProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _7oct1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Password", c => c.String());
            AlterColumn("dbo.Students", "DOB", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "DOB", c => c.DateTime());
            DropColumn("dbo.Students", "Password");
        }
    }
}
