using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechProject.Data.Models;


/// <summary>
/// IRepository interface 
/// Developed by : Aman Kothari
/// Date : 27-sept-2015
/// </summary>
namespace TechProject.Data
{
   public interface IRepository
    {
        //Corses Interface
        #region Courses
        List<Courses> GetcourseList();
        Courses Getcourse(int CourseId);
        Courses Addcourse(Courses courseObj);
        bool Updatecourse(Courses courseObj);
        bool Deletecourse(int courseId);
        #endregion


        #region Admin
        List<Admin> GetAllAdmin();
        Admin GetAdmin(int adminId);
        Admin AddAdmin(Admin courseObj);
        bool UpdateAdmin(Admin courseObj);
        bool DeleteAdmin(int adminId);
        #endregion

        #region StudentQuery
        List<StudentQuery> GetAllstudentQuery();
        StudentQuery GetstudentQuery(int QueryId);
        StudentQuery AddstudentQuery(StudentQuery QueryObj);
        bool UpdatestudentQuery(StudentQuery QueryObj);
        bool DeletestudentQuery(int QueryId);
        #endregion

        #region Login
        List<Login> GetAllLogins();
        Login Getlogin(int loginId);
        Login Addlogin(Login loginObj);
        bool Updatelogin(Login loginObj);
        bool Deletelogin(int loginId);
        #endregion

        #region Student
        void AddStudentList(IList<Student> Students);
        Courses GetCourse(string course);
        #endregion
    }
}
