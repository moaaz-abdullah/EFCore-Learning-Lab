using EFCore.Models;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new AppDbContext();

            db.SaveChanges();

        }
    }
}
