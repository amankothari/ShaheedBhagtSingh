

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechProject.Data.Models;

/// <summary>
/// Repository.cs 
/// This file contains all necessary functions that we are calling in API's
/// Developed by : Aman Kothari
/// Date : 27-sept-2015
/// </summary>

namespace TechProject.Data
{
    public class Repository : IRepository
    {
        private DataContext _context;
        public Repository(DataContext context)
        {
            _context = context;
        }

        #region Courses
        /// <summary>
        /// Get all courses
        /// </summary>
        /// <returns></returns>
        public List<Courses> GetcourseList()
        {
            try
            {
                return _context.Courses.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Get single course
        /// </summary>
        /// <returns></returns>
        public Courses Getcourse(int CourseId)
        {
            try
            {
                return _context.Courses.Where(x=>x.CourseId== CourseId).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// add new course using this method
        /// </summary>
        /// <param name="courseObj"></param>
        /// <returns></returns>
        public Courses Addcourse(Courses courseObj)
        {
            try
            {
                courseObj.CreatedDate = DateTime.Now;
                courseObj.ModifiedDate = DateTime.Now;
                Courses newcourse =_context.Courses.Add(courseObj);
                SaveContext();
                return newcourse;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// update course using thie method
        /// </summary>
        /// <param name="courseObj"></param>
        /// <returns></returns>
        public bool Updatecourse(Courses courseObj)
        {
            try
            {
                Courses course = _context.Courses.Where(x => x.CourseId == courseObj.CourseId).FirstOrDefault();
                if(course != null)
                {
                    course.CourseFee = courseObj.CourseFee;
                    course.CourseName = courseObj.CourseName;
                    course.Duration = courseObj.Duration;
                    course.NumberOfsemester = courseObj.NumberOfsemester;
                    course.ModifiedDate = DateTime.Now;
                    _context.Entry(course).State = System.Data.Entity.EntityState.Modified;
                    SaveContext();
                    return true;
                }return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// delete course using this metrhod
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns></returns>
        public bool Deletecourse(int courseId)
        {
            try
            {
                Courses course = _context.Courses.Where(x => x.CourseId == courseId).FirstOrDefault();
                if (course != null)
                {
                    _context.Entry(course).State = System.Data.Entity.EntityState.Deleted;
                    SaveContext();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Admin
        public List<Admin> GetAllAdmin()
        {
            try
            {
                return _context.Admins.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Admin GetAdmin(int adminId)
        {
            try
            {
                return _context.Admins.Where(x => x.AdminId == adminId).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Admin AddAdmin(Admin Adminobj)
        {
            try
            {
                Admin newAdminobj = _context.Admins.Add(Adminobj);
                SaveContext();
                return newAdminobj;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool UpdateAdmin(Admin AdminObj)
        {
            try
            {
                Admin admin = _context.Admins.Where(x => x.AdminId == AdminObj.AdminId).FirstOrDefault();
                if (admin != null)
                {
                    admin.Address = AdminObj.Address;
                    admin.City = AdminObj.City;
                    admin.Email = AdminObj.Email;
                    admin.FirstName = AdminObj.FirstName;
                    admin.MobileNumber = AdminObj.MobileNumber;
                    admin.Pincode = AdminObj.Pincode;
                    admin.sex = AdminObj.sex;
                    _context.Entry(admin).State = System.Data.Entity.EntityState.Modified;
                    SaveContext();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool DeleteAdmin(int adminId)
        {
            try
            {
                Admin admin = _context.Admins.Where(x => x.AdminId == adminId).FirstOrDefault();
                if (admin != null)
                {
                    _context.Entry(admin).State = System.Data.Entity.EntityState.Deleted;
                    SaveContext();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region StudentQueries
        public List<StudentQuery> GetAllstudentQuery()
        {
            try
            {
                return _context.StudentQueries.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public StudentQuery GetstudentQuery(int QueryId)
        {
            try
            {
                return _context.StudentQueries.Where(x => x.QueryId == QueryId).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public StudentQuery AddstudentQuery(StudentQuery StudentQueryObj)
        {
            try
            {
                StudentQueryObj.CreatedDate = DateTime.Now;
                StudentQueryObj.ModifiedDate = DateTime.Now;
                StudentQuery queries = _context.StudentQueries.Add(StudentQueryObj);
                SaveContext();
                return queries;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public bool UpdatestudentQuery(StudentQuery QueryObj)
        {
            try
            {
                StudentQuery getQuery = _context.StudentQueries.Where(x => x.QueryId == QueryObj.QueryId).FirstOrDefault();
                if (getQuery != null)
                {
                    getQuery = QueryObj;
                    _context.Entry(getQuery).State = System.Data.Entity.EntityState.Modified;
                    SaveContext();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool DeletestudentQuery(int adminId)
        {
            try
            {
                StudentQuery getQuery = _context.StudentQueries.Where(x => x.QueryId == adminId).FirstOrDefault();
                if (getQuery != null)
                {
                    _context.Entry(getQuery).State = System.Data.Entity.EntityState.Deleted;
                    SaveContext();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region Login
        public List<Login> GetAllLogins()
        {
            try
            {
                return _context.Logins.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Login Getlogin(Login obj)
        {
            try
            {
                return _context.Logins.Where(x => x.UserName == obj.UserName && x.Password==obj.Password).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Login Addlogin(Login LoginObj)
        {
            try
            {
                Login Loginnew = _context.Logins.Add(LoginObj);
                SaveContext();
                return Loginnew;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Updatelogin(Login LoginObj)
        {
            try
            {
                Login newlogin = _context.Logins.Where(x => x.LoginId == LoginObj.LoginId).FirstOrDefault();
                if (newlogin != null)
                {
                    newlogin = LoginObj;
                    _context.Entry(newlogin).State = System.Data.Entity.EntityState.Modified;
                    SaveContext();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Deletelogin(int adminId)
        {
            try
            {
                Login newlogin = _context.Logins.Where(x => x.LoginId == adminId).FirstOrDefault();
                if (newlogin != null)
                {
                    _context.Entry(newlogin).State = System.Data.Entity.EntityState.Modified;
                    SaveContext();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region Student
        /// <summary>
        /// Method for save all excel rows in database
        /// </summary>
        /// <param name="Students"></param>
         public void AddStudentList(IList<Student> Students)
        {
            try
            {
                EFExtension.AddRange(_context.Students, Students);
                SaveContext();
            }
            catch (Exception)
            {

                throw;
            }
        }
         public Courses GetCourse(string course)
        {
            try
            {
                return _context.Courses.Where(x => x.CourseName == course).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }
          public Student GetStudentById(string LoginId)
        {
            try
            {
                return _context.Students.Where(x => x.ApplicantID == LoginId).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }
          public Student GetStudentlogin(Student std)
        {
            try
            {
                var a= _context.Students.Where(x => x.ApplicantID == std.ApplicantID && x.Password==std.Password).FirstOrDefault();
                return a;
            }
            catch (Exception)
            {

                throw;
            }
        }



        public Student UpdateStudentProfile(Student std)
        {
            try
            {
                Student getstd = _context.Students.Where(x => x.ApplicantID == std.ApplicantID).FirstOrDefault();
                if (getstd != null)
                {
                    getstd.aadharcertURL = std.aadharcertURL;
                    getstd.cert10thURL = std.cert10thURL;
                    getstd.cert12thURL = std.cert12thURL;
                    getstd.domicilecertURL = std.domicilecertURL;
                    getstd.ModifiedDate = DateTime.Now;
                    _context.Entry(getstd).State = System.Data.Entity.EntityState.Modified;
                    SaveContext();
                    return getstd;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion


        public void SaveContext()
        {
            _context.SaveChanges();
        }

    }
}
