using System;
using System.Collections.Generic;
using System.Text;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Connections.SqlConnectionString);
        }

        public DbSet<Models.Student> Students { get; set; }

        public DbSet<Models.Department> Departments { get; set; }

        public DbSet<Models.Grade> Grades { get; set; }

        public DbSet<Models.Book> Books { get; set; }

        public DbSet<Models.StudentBook> StudentBooks { get; set; }

        public DbSet<Models.Attendance> Attendances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region
            // modelBuilder.Entity<Department>().Property(x => x.Description).IsRequired();

            //modelBuilder.Entity<Department>()
            //    .HasMany(s => s.Students)
            //    .WithOne(d => d.Department)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Student>()
            //    .HasOne(g => g.GradeDetails)
            //    .WithOne(s => s.Student)
            //    .OnDelete(DeleteBehavior.SetNull);
            #endregion

            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

        }
    }
}
