using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechProject.Data.Models;

/// <summary>
/// Datacontext.cs 
/// interacting for sql database
/// Developed by : Aman Kothari
/// Date : 27-sept-2015
/// </summary>
namespace TechProject.Data
{
    public class DataContext : DbContext
    {
        public DataContext():base(@"ConnectionString")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;

        }

        public DbSet<StudentQuery> StudentQueries { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public DbSet<Login> Logins { get; set; }
        public DbSet<Courses> Courses { get; set; }

    }
}
