////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Date         Name            Description
//2021-03-12   Simran Kaur     -creation of class SchoolContext in data folder

using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        //tinfo200:[2021-03-12-simrank2-dykstra2] - constructor
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        //tinfo200:[2021-03-12-simrank2-dykstra2] - telling these entities that our database has to take a course, enrollment, and a student in the school context
        //tinfo200:[2021-03-12-simrank2-dykstra2] - basically telling entities to relate courses, enrollments, and students to each other
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        //tinfo200:[2021-03-12-simrank2-dykstra2] - method on model creating 
        //tinfo200:[2021-03-12-simrank2-dykstra2] - explicitly telling entity framework what names you want it to give to the tables
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
