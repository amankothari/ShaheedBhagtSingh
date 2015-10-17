namespace TechProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _17oct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Description", c => c.String(maxLength: 5000, unicode: false));
            AlterColumn("dbo.Courses", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Courses", "ModifiedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "ModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Courses", "CreatedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Courses", "Description");
        }
    }
}
