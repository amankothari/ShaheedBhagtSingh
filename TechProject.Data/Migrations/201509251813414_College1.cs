namespace TechProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class College1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StudentQueries", "Category", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StudentQueries", "Category", c => c.String(maxLength: 4000));
        }
    }
}
