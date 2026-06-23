using EFCore.Models;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _context = new AppDbContext();
            var _students = new Student[]
            {
                new Student { Name = "Alice", Age = 20 , Email = "alice@example.com" , Grade = 85 },
                new Student { Name = "Bob", Age = 22 , Email = "bob@example.com" , Grade = 78 },
                new Student { Name = "Charlie", Age = 21 , Email = "charlie@example.com" , Grade = 92 }
            };

            _context.Students.AddRange(_students);
            _context.SaveChanges();
        }
    }
}
