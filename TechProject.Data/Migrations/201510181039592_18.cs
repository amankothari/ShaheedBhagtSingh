namespace TechProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _18 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        Isdeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        FacultyId = c.Int(nullable: false, identity: true),
                        EmployeeID = c.String(maxLength: 50),
                        Name = c.String(maxLength: 50),
                        DOB = c.String(),
                        SO = c.String(maxLength: 100),
                        Gender = c.Int(nullable: false),
                        Address = c.String(maxLength: 1000),
                        City = c.String(maxLength: 100),
                        PostalCode = c.String(maxLength: 100),
                        State = c.String(maxLength: 100),
                        PermanentAddress = c.String(maxLength: 1000),
                        PermanentCity = c.String(maxLength: 100),
                        PermanentPostalCode = c.String(maxLength: 100),
                        PermanentState = c.String(maxLength: 100),
                        Country = c.String(maxLength: 100),
                        PhotoURL = c.String(),
                        PersonalContact = c.String(maxLength: 100),
                        Email = c.String(),
                        HomeContact = c.String(maxLength: 100),
                        EducationType = c.String(),
                        Education = c.String(),
                        JobType = c.String(),
                        Designation = c.String(),
                        JoiningDate = c.String(),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        Isdeleted = c.Boolean(nullable: false),
                        Department_DepartmentId = c.Int(),
                    })
                .PrimaryKey(t => t.FacultyId)
                .ForeignKey("dbo.Departments", t => t.Department_DepartmentId)
                .Index(t => t.Department_DepartmentId);
            
            AddColumn("dbo.Courses", "Description", c => c.String(maxLength: 5000, unicode: false));
            AlterColumn("dbo.Courses", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Courses", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Logins", "Mobile", c => c.String(maxLength: 4000));
            AlterColumn("dbo.Students", "Password", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Faculties", "Department_DepartmentId", "dbo.Departments");
            DropIndex("dbo.Faculties", new[] { "Department_DepartmentId" });
            AlterColumn("dbo.Students", "Password", c => c.String());
            AlterColumn("dbo.Logins", "Mobile", c => c.Long(nullable: false));
            AlterColumn("dbo.Courses", "ModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Courses", "CreatedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Courses", "Description");
            DropTable("dbo.Faculties");
            DropTable("dbo.Departments");
        }
    }
}
