namespace TechProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Chnges2oct2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "AdYear", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "AdYear", c => c.DateTime());
        }
    }
}
