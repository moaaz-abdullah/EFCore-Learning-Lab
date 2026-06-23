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

    }
}
