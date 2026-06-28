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

        public DbSet<Models.Invoice> Invoices { get; set; }

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

            //foreach (var relationship in modelBuilder.Model.GetEntityTypes()
            //    .SelectMany(t => t.GetForeignKeys()))
            //{
            //    relationship.DeleteBehavior = DeleteBehavior.Restrict;
            //}

            #endregion

            // Using Fluent API to
            // configure the table name and schema for the Attendance entity
            // configure the column name and type for the DayName property in the Attendance entity

            modelBuilder.Entity<Attendance>().ToTable("StudentAttendances", "std");

            modelBuilder.Entity<Attendance>().Property(a => a.DayName)
                .HasColumnName("NameOfTheDay")
                .HasColumnType("nvarchar(20)");

            // This property will not be mapped to the database
            modelBuilder.Entity<Attendance>().Ignore(a => a.Date);


            // Using Fluent API to configure the Invoice entity 
            modelBuilder.Entity<Invoice>().Property(f => f.CustomerFullname)
                .HasComputedColumnSql("CONCAT([CustomerFirstName], ' ', [CustomerLastName])");

            modelBuilder.Entity<Invoice>().Property(t => t.Total)
                .HasComputedColumnSql("[Quantity] * [Price]");

            modelBuilder.Entity<Invoice>().Property(d => d.CreatedDate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Invoice>().Property(q => q.Quantity)
                .HasDefaultValue(1);

            // Create a composite index on the Name and Email properties of the Student entity
            modelBuilder.Entity<Student>().HasIndex(s => new { s.Name, s.Email });

            modelBuilder.HasSequence<int>("Delivery Order")
                .StartsAt(1000)
                .IncrementsBy(1);

            modelBuilder.Entity<Book>()
                .Property(b => b.DeliveryOrder)
                .HasDefaultValueSql("NEXT VALUE FOR [Delivery Order]");
        
            modelBuilder.Entity<Student>()
                .Property(s => s.DeliveryOrder)
                .HasDefaultValueSql("NEXT VALUE FOR [Delivery Order]");

        }
    }
}
