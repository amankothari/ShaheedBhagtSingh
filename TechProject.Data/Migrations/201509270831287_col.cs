namespace TechProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class col : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 100, unicode: false),
                        sex = c.Int(nullable: false),
                        MobileNumber = c.Long(nullable: false),
                        Email = c.String(maxLength: 256),
                        Address = c.String(maxLength: 256),
                        City = c.String(maxLength: 100, unicode: false),
                        Pincode = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        CourseName = c.String(maxLength: 100, unicode: false),
                        Duration = c.Int(nullable: false),
                        CourseFee = c.Int(nullable: false),
                        NumberOfsemester = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseId);
            
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        LoginId = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 100, unicode: false),
                        Email = c.String(maxLength: 256),
                        Mobile = c.Long(nullable: false),
                        Password = c.String(maxLength: 256),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LoginId);
            
            CreateTable(
                "dbo.StudentQueries",
                c => new
                    {
                        QueryId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 100, unicode: false),
                        LastName = c.String(maxLength: 100, unicode: false),
                        Category = c.Int(nullable: false),
                        Gender = c.Int(nullable: false),
                        MobileNumber = c.Long(nullable: false),
                        Email = c.String(maxLength: 256),
                        City = c.String(maxLength: 100, unicode: false),
                        Pincode = c.String(maxLength: 100, unicode: false),
                        PassoutYear10th = c.Int(nullable: false),
                        Percentage10th = c.Int(nullable: false),
                        SchoolName10th = c.String(maxLength: 100, unicode: false),
                        PassoutYear12th = c.Int(nullable: false),
                        Percentage12th = c.Int(nullable: false),
                        SchoolName12th = c.String(maxLength: 100, unicode: false),
                        Interest = c.String(),
                        Course_CourseId = c.Int(),
                    })
                .PrimaryKey(t => t.QueryId)
                .ForeignKey("dbo.Courses", t => t.Course_CourseId)
                .Index(t => t.Course_CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentQueries", "Course_CourseId", "dbo.Courses");
            DropIndex("dbo.StudentQueries", new[] { "Course_CourseId" });
            DropTable("dbo.StudentQueries");
            DropTable("dbo.Logins");
            DropTable("dbo.Courses");
            DropTable("dbo.Admins");
        }
    }
}
