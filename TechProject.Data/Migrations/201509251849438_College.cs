namespace TechProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class College : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentQueries", "Gender", c => c.Int(nullable: false));
            AlterColumn("dbo.Admins", "FirstName", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Admins", "MobileNumber", c => c.Long(nullable: false));
            AlterColumn("dbo.Admins", "Email", c => c.String(maxLength: 256));
            AlterColumn("dbo.Admins", "Address", c => c.String(maxLength: 256));
            AlterColumn("dbo.Admins", "City", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Admins", "Pincode", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Courses", "CourseName", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Logins", "UserName", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.Logins", "Email", c => c.String(maxLength: 256));
            AlterColumn("dbo.Logins", "Password", c => c.String(maxLength: 256));
            AlterColumn("dbo.StudentQueries", "FirstName", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.StudentQueries", "LastName", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.StudentQueries", "Email", c => c.String(maxLength: 256));
            AlterColumn("dbo.StudentQueries", "City", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.StudentQueries", "Pincode", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.StudentQueries", "SchoolName10th", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.StudentQueries", "SchoolName12th", c => c.String(maxLength: 100, unicode: false));
            DropColumn("dbo.StudentQueries", "sex");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StudentQueries", "sex", c => c.Int(nullable: false));
            AlterColumn("dbo.StudentQueries", "SchoolName12th", c => c.String(maxLength: 8000, unicode: false));
            AlterColumn("dbo.StudentQueries", "SchoolName10th", c => c.String(maxLength: 8000, unicode: false));
            AlterColumn("dbo.StudentQueries", "Pincode", c => c.String(maxLength: 8000, unicode: false));
            AlterColumn("dbo.StudentQueries", "City", c => c.String(maxLength: 8000, unicode: false));
            AlterColumn("dbo.StudentQueries", "Email", c => c.String(maxLength: 4000));
            AlterColumn("dbo.StudentQueries", "LastName", c => c.String(maxLength: 8000, unicode: false));
            AlterColumn("dbo.StudentQueries", "FirstName", c => c.String(maxLength: 8000, unicode: false));
            AlterColumn("dbo.Logins", "Password", c => c.String(maxLength: 4000));
            AlterColumn("dbo.Logins", "Email", c => c.String(maxLength: 4000));
            AlterColumn("dbo.Logins", "UserName", c => c.String(maxLength: 8000, unicode: false));
            AlterColumn("dbo.Courses", "CourseName", c => c.String(maxLength: 8000, unicode: false));
            AlterColumn("dbo.Admins", "Pincode", c => c.String(maxLength: 8000, unicode: false));
            AlterColumn("dbo.Admins", "City", c => c.String(maxLength: 8000, unicode: false));
            AlterColumn("dbo.Admins", "Address", c => c.String(maxLength: 4000));
            AlterColumn("dbo.Admins", "Email", c => c.String(maxLength: 4000));
            AlterColumn("dbo.Admins", "MobileNumber", c => c.String(maxLength: 4000));
            AlterColumn("dbo.Admins", "FirstName", c => c.String(maxLength: 8000, unicode: false));
            DropColumn("dbo.StudentQueries", "Gender");
        }
    }
}
