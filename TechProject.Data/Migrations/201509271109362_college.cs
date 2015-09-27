namespace TechProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class college : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentQueries", "Stream", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StudentQueries", "Stream");
        }
    }
}
