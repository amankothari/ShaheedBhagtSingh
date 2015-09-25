using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechProject.Data.Models;

namespace TechProject.Data
{
    public class DataContext : DbContext
    {
        public DataContext():base(@"ConnectionString")
        {

        }

        public DbSet<StudentQuery> StudentQueries { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public DbSet<Login> Logins { get; set; }
        public DbSet<Courses> Courses { get; set; }

    }
}
