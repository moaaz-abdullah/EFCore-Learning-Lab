using System.ComponentModel.DataAnnotations;
using EFCore.Models;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new AppDbContext();
            var dept = new Department()
            {
                Name = "CS",
                Description = "Computer Science"
            };

            var context = new ValidationContext(dept, serviceProvider: null, items: null);
            var errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(dept, context, errors, true))
            {
                foreach (var error in errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            else
            {
                db.Departments.Add(dept);
                db.SaveChanges();
            }
        }
    }
}
