using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.BLL.Models;

namespace University.BLL.Data
{
    public class UniversityContext:DbContext
    {
        public UniversityContext() : base("name=conexion") { }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        //patrón de singleton
        public static UniversityContext Create()
        {
            return new UniversityContext();
        }
    }
}
