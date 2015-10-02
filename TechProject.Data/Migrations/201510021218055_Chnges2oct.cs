namespace TechProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Chnges2oct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        ApplicantID = c.String(maxLength: 50),
                        Name = c.String(maxLength: 50),
                        DOB = c.DateTime(nullable: false),
                        SO = c.String(maxLength: 100),
                        Gender = c.Int(nullable: false),
                        Category = c.Int(nullable: false),
                        AdYear = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        Isdeleted = c.Boolean(nullable: false),
                        Course_CourseId = c.Int(),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Courses", t => t.Course_CourseId)
                .Index(t => t.Course_CourseId);
            
            AddColumn("dbo.Admins", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Admins", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Admins", "Isdeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Courses", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Courses", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Courses", "Isdeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Logins", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Logins", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Logins", "Isdeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.StudentQueries", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.StudentQueries", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.StudentQueries", "Isdeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Course_CourseId", "dbo.Courses");
            DropIndex("dbo.Students", new[] { "Course_CourseId" });
            DropColumn("dbo.StudentQueries", "Isdeleted");
            DropColumn("dbo.StudentQueries", "ModifiedDate");
            DropColumn("dbo.StudentQueries", "CreatedDate");
            DropColumn("dbo.Logins", "Isdeleted");
            DropColumn("dbo.Logins", "ModifiedDate");
            DropColumn("dbo.Logins", "CreatedDate");
            DropColumn("dbo.Courses", "Isdeleted");
            DropColumn("dbo.Courses", "ModifiedDate");
            DropColumn("dbo.Courses", "CreatedDate");
            DropColumn("dbo.Admins", "Isdeleted");
            DropColumn("dbo.Admins", "ModifiedDate");
            DropColumn("dbo.Admins", "CreatedDate");
            DropTable("dbo.Students");
        }
    }
}
