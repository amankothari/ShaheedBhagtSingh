namespace TechProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class College : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "cert10thURL", c => c.String());
            AddColumn("dbo.Students", "cert12thURL", c => c.String());
            AddColumn("dbo.Students", "domicilecertURL", c => c.String());
            AddColumn("dbo.Students", "aadharcertURL", c => c.String());
            AddColumn("dbo.Students", "Password", c => c.String());
            AlterColumn("dbo.Students", "DOB", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "DOB", c => c.DateTime());
            DropColumn("dbo.Students", "Password");
            DropColumn("dbo.Students", "aadharcertURL");
            DropColumn("dbo.Students", "domicilecertURL");
            DropColumn("dbo.Students", "cert12thURL");
            DropColumn("dbo.Students", "cert10thURL");
        }
    }
}
