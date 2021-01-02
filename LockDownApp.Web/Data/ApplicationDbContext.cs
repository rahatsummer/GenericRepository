using System;
using System.Collections.Generic;
using System.Text;
using LockDownApp.Web.Models.SchoolModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LockDownApp.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });
            builder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(sc => sc.StudentCourses)
                .HasForeignKey(s => s.StudentId);

            builder.Entity<StudentCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(sc => sc.StudentCourses)
                .HasForeignKey(s => s.CourseId);

            base.OnModelCreating(builder);
        }
    }
}
