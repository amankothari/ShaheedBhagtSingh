namespace TechProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removebigint : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Logins", "Mobile", c => c.String(maxLength: 4000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Logins", "Mobile", c => c.Long(nullable: false));
        }
    }
}
