namespace TechProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class oct11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StudentQueries", "MobileNumber", c => c.String(maxLength: 4000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StudentQueries", "MobileNumber", c => c.String(maxLength: 100));
        }
    }
}
