namespace TechProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _11final : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "cert10thURL", c => c.String());
            AddColumn("dbo.Students", "cert12thURL", c => c.String());
            AddColumn("dbo.Students", "domicilecertURL", c => c.String());
            AddColumn("dbo.Students", "aadharcertURL", c => c.String());
            AlterColumn("dbo.Logins", "Mobile", c => c.String(maxLength: 4000));
            AlterColumn("dbo.StudentQueries", "MobileNumber", c => c.String(maxLength: 4000));
            AlterColumn("dbo.Students", "Password", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Password", c => c.String());
            AlterColumn("dbo.StudentQueries", "MobileNumber", c => c.String(maxLength: 100));
            AlterColumn("dbo.Logins", "Mobile", c => c.Long(nullable: false));
            DropColumn("dbo.Students", "aadharcertURL");
            DropColumn("dbo.Students", "domicilecertURL");
            DropColumn("dbo.Students", "cert12thURL");
            DropColumn("dbo.Students", "cert10thURL");
        }
    }
}
